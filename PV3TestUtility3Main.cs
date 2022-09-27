using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PV3TestUtility3
{
    public partial class PV3TestUtility3Main : Form
    {
        USBClass usbConnection;                         // Normal working connection (non-bootloader)
        public USBClass USBConnection
        {
            get { return usbConnection; }
            set { usbConnection = value; }
        }

        USBClass blConnection;                          // Bootloader connection
        public USBClass BLConnection
        {
            get { return blConnection; }
            set {blConnection = value; }
        }

        Stopwatch dataStopwatch = new Stopwatch();
        
        PV3DataTypes pv3Data = new PV3DataTypes();

        internal PV3DataTypes PV3Data
        {
            get { return pv3Data; }
            set { pv3Data = value; }
        }

        PV3DataTypes.PV3CommandType cmd;

        private uint AUXINValue;
        byte ttlModel = 0;                              //Flag indicating the TTL model attached
        byte[] ttlSN = new byte[2];                     //Byte array for the serial number of the TTL attached


        //Constant definitions for certain WM_DEVICECHANGE messages
        internal const uint WM_DEVICECHANGE = 0x0219;
        internal const uint DBT_DEVICEARRIVAL = 0x8000;
        internal const uint DBT_DEVICEREMOVEPENDING = 0x8003;
        internal const uint DBT_DEVICEREMOVECOMPLETE = 0x8004;
        internal const uint DBT_DEVNODES_CHANGED = 0x0007;
        internal const uint DBT_CONFIGCHANGED = 0x0018;

        internal const uint HSDP_SAMPLES = 10000;

        double minTime = 0.0;
        double maxTime = 10.0;

        ScottPlot.Plottable.SignalPlot airwayPressureSignal;
        ScottPlot.Plottable.SignalPlot leftLungPressureSignal;
        ScottPlot.Plottable.SignalPlot rightLungPressureSignal;
        ScottPlot.Plottable.SignalPlot volumeSignal;
        ScottPlot.Plottable.SignalPlot leftVolumeSignal;
        ScottPlot.Plottable.SignalPlot rightVolumeSignal;
        ScottPlot.Plottable.SignalPlot flowSignal;

        private double displayUpdateInterval = 0.010;
        public double DisplayUpdateInterval { get => displayUpdateInterval; set => displayUpdateInterval = value; }


        // Constructor
        public PV3TestUtility3Main()
        {
            InitializeComponent();
            usbConnection = new USBClass();
            usbConnection.deviceID = "Vid_04D8&Pid_FCB6";
            blConnection = new USBClass();
            blConnection.deviceID = "Vid_04D8&Pid_003C";
        }

        #region Main form event handlers

        // This is a callback function that gets called when a Windows message is received by the form.
        // We will receive various different types of messages, but the ones we really want to use are the WM_DEVICECHANGE messages.
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                if (((int)m.WParam == DBT_DEVICEARRIVAL) 
                 || ((int)m.WParam == DBT_DEVICEREMOVEPENDING) 
                 || ((int)m.WParam == DBT_DEVICEREMOVECOMPLETE)
                 || ((int)m.WParam == DBT_DEVNODES_CHANGED)
                 || ((int)m.WParam == DBT_CONFIGCHANGED))
                {
                    // Added DBT_DEVNODES_CHANGED wParam
                    // This was done to work around the issue encountered with the ARRIVAL, REMOVAL or CONFIGCHANGE
                    //parameters apparently no longer arriving after the MSD functions were removed from the firmware
                    ConnectToUSB();
                }

            } //end of: if(m.Msg == WM_DEVICECHANGE)
            base.WndProc(ref m);
        } //end of: WndProc() function

        private void PV3TestUtility3Main_Load(object sender, EventArgs e)
        {
            if (usbConnection.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL || blConnection.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL)
            {
                ConnectToUSB();
            }

            DisplayUpdateInterval = usbCommTimer.Interval / 1000.0;

            PressuresPlot.Plot.XAxis.TickLabelFormat("0.000", false);
            PressuresPlot.Plot.XAxis.LabelStyle(fontSize: 10);
            PressuresPlot.Plot.XLabel("Time (s)");

            PressuresPlot.Plot.YAxis.TickLabelFormat("0.00", false);
            PressuresPlot.Plot.YAxis.LabelStyle(fontSize: 10);
            PressuresPlot.Plot.YLabel("Airway Pressure (cmH2O)");

            PressuresPlot.Plot.YAxis2.TickLabelFormat("0.00", false);
            PressuresPlot.Plot.YAxis2.Ticks(true);
            PressuresPlot.Plot.YAxis2.LabelStyle(fontSize: 10);
            PressuresPlot.Plot.YAxis2.Label("Lung Pressure (cmH2O)");
            PressuresPlot.Plot.YAxis2.Edge = ScottPlot.Renderable.Edge.Right;
            PressuresPlot.Plot.YAxis2.IsVisible = true;

            VolumeFlowPlot.Plot.XAxis.TickLabelFormat("0.000", false);
            VolumeFlowPlot.Plot.XAxis.LabelStyle(fontSize: 10);
            VolumeFlowPlot.Plot.XLabel("Time (s)");

            VolumeFlowPlot.Plot.YAxis.TickLabelFormat("0", false);
            VolumeFlowPlot.Plot.YAxis.LabelStyle(fontSize: 10);
            VolumeFlowPlot.Plot.YLabel("Volume (mL)");

            // DONE: Second Y axis doesn't seem to appear...
            VolumeFlowPlot.Plot.YAxis2.TickLabelFormat("0.0", false);
            VolumeFlowPlot.Plot.YAxis2.Ticks(true);
            VolumeFlowPlot.Plot.YAxis2.LabelStyle(fontSize: 10);
            VolumeFlowPlot.Plot.YAxis2.Label("Flow (L/min)");
            VolumeFlowPlot.Plot.YAxis2.Edge = ScottPlot.Renderable.Edge.Right;
            VolumeFlowPlot.Plot.YAxis2.IsVisible = true;

            SetDefaultAxisLimits();

            airwayPressureSignal = PressuresPlot.Plot.AddSignal(pv3Data.airwayPressureStream, PV3DataTypes.SampleRate, Color.Aqua, "Airway");
            leftLungPressureSignal = PressuresPlot.Plot.AddSignal(pv3Data.leftLungPressureStream, PV3DataTypes.SampleRate, Color.Green, "Left");
            leftLungPressureSignal.YAxisIndex = 1;
            rightLungPressureSignal = PressuresPlot.Plot.AddSignal(pv3Data.rightLungPressureStream, PV3DataTypes.SampleRate, Color.Blue, "Right");
            rightLungPressureSignal.YAxisIndex = 1;

            volumeSignal = VolumeFlowPlot.Plot.AddSignal(pv3Data.volumeStream, PV3DataTypes.SampleRate, Color.OrangeRed, "Total");
            leftVolumeSignal = VolumeFlowPlot.Plot.AddSignal(pv3Data.leftVolumeStream, PV3DataTypes.SampleRate, Color.Orange, "Left");
            leftVolumeSignal.YAxisIndex = 0;
            rightVolumeSignal = VolumeFlowPlot.Plot.AddSignal(pv3Data.rightVolumeStream, PV3DataTypes.SampleRate, Color.Red, "Right");
            rightVolumeSignal.YAxisIndex = 0;

            flowSignal = VolumeFlowPlot.Plot.AddSignal(pv3Data.flowStream, PV3DataTypes.SampleRate, Color.Purple, "Flow");
            flowSignal.YAxisIndex = 1;

            PressuresPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            VolumeFlowPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);

            PressuresPlot.Render();
            VolumeFlowPlot.Render();

        }

        private void PV3TestUtility3Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                if (FactoryControlPanel.Dock == DockStyle.None)
                {
                    FactoryControlPanel.Dock = DockStyle.Bottom;
                }
                else
                {
                    FactoryControlPanel.Dock = DockStyle.None;
                }
            }
        }

        #endregion Main form event handlers

        // Connect to PV3 embedded system over USB
        public bool ConnectToUSB()
        {
            System.Threading.Thread.Sleep(500);
            usbConnection.connectionState = usbConnection.attemptUSBConnection();
            if (usbConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                connectionStateLabel.BackColor = Color.LimeGreen;
                connectionStateLabel.Text = "Connected to: " + usbConnection.deviceID;
                usbCommTimer.Enabled = false;

                // Configure the form controls for a connected device:

                //TODO: Read lung information (Model, SN, calibration data, compliance coefficient tables):



                return true;
            }
            blConnection.connectionState = blConnection.attemptUSBConnection();
            if (blConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                connectionStateLabel.BackColor = Color.LightBlue;
                connectionStateLabel.Text = "Connected to: " + blConnection.blDeviceID;
                usbCommTimer.Enabled = false;

                // Configure the form controls as appropriate for being connected to the HID Bootloader:


                return true;
            } else
            {
                connectionStateLabel.BackColor = Color.Red;
                connectionStateLabel.Text = "NOT Connected - click to retry...";
                usbCommTimer.Enabled = false;
                
                // Configure the form controls as appropriate while waqiting for device to connect:


                return false;
            }

        }

        #region Factory panel event handlers

        public void DisplayUSBBufferData()
        {
            string usbOutString = "";
            string usbInString = "";

            for (int i = 1; i < 17; ++i)
            {
                usbOutString += string.Format("{0:X2} ", usbConnection.OutBuffer[i]);
                usbInString += string.Format("{0:X2} ", usbConnection.InBuffer[i]);
            }
            usbOutDisplayLabel.Text = usbOutString;
            usbInDisplayLabel.Text = usbInString;
        }

        private void SetDefaultAxisLimits()
        {
            minTime = 0.0;
            maxTime = 10.0;

            PressuresPlot.Plot.SetAxisLimitsX(minTime, maxTime);
            PressuresPlot.Plot.SetAxisLimitsY(0.0, 120.0);
            PressuresPlot.Plot.SetAxisLimits(yMin: 0.0, yMax: 120.0, yAxisIndex: 1);

            VolumeFlowPlot.Plot.SetAxisLimitsX(minTime, maxTime);
            VolumeFlowPlot.Plot.SetAxisLimitsY(0, 2000);
            VolumeFlowPlot.Plot.SetAxisLimits(yMin: -60.0, yMax: 60.0, yAxisIndex: 1);

        }

        private void connectionStateLabel_Click(object sender, EventArgs e)
        {
            ConnectToUSB();
        }

        private void toggleLEDsButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.TOGGLE_LEDS;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            DisplayUSBBufferData();
        }

        private void toggleBlinkStatusButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.TOGGLE_BLINKSTATUS;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            DisplayUSBBufferData();
        }

        private void enterBootloaderButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.BOOTLOAD;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            DisplayUSBBufferData();
            ConnectToUSB();
        }

        private void resetMCUButton_Click(object sender, EventArgs e)
        {
            if (blConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                cmd = PV3DataTypes.PV3CommandType.RESET_FROM_BOOTLOADER;
                blConnection.OutBuffer[1] = (byte)cmd;
                blConnection.sendViaUSB();
                DisplayUSBBufferData();
            }
            else if (usbConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                cmd = PV3DataTypes.PV3CommandType.RESET;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
                DisplayUSBBufferData();
            }
            ConnectToUSB();
        }

        private void readLungModelButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_LUNG_MODEL;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            
            usbConnection.receiveViaUSB();
            ttlModel = usbConnection.InBuffer[2];
            switch (ttlModel)
            {
                case 1:
                    lungModelDisplayLabel.Text = "Single Lung";
                    break;
                case 2:
                    lungModelDisplayLabel.Text = "Adult / Infant";
                    break;
                case 4:
                    lungModelDisplayLabel.Text = "Dual Adult";
                    break;

                default:
                    lungModelDisplayLabel.Text = string.Format("Invalid flag set: {0:X2}", ttlModel);
                    break;
            }
            DisplayUSBBufferData();
        }

        private void writeLungModelButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.SET_LUNG_MODEL;
            usbConnection.OutBuffer[1] = (byte)cmd;
            ttlModel = Convert.ToByte(lungModelTextBox.Text);
            usbConnection.OutBuffer[2] = ttlModel;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            lungModelDisplayLabel.Text = "Model flag not read";
            DisplayUSBBufferData();
        }

        private void readLungSerialNumberButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_LUNG_SN;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            ttlSN[0] = usbConnection.InBuffer[2];
            ttlSN[1] = usbConnection.InBuffer[3];
            lungSerialNumberDisplayLabel.Text = (BitConverter.ToUInt16(ttlSN, 0)).ToString();
            DisplayUSBBufferData();
        }

        private void writeLungSerialNumberButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.SET_LUNG_SN;
            usbConnection.OutBuffer[1] = (byte)cmd;
            ushort intSN = Convert.ToUInt16(lungSerialNumberTextBox.Text);
            ttlSN = BitConverter.GetBytes(intSN);
            usbConnection.OutBuffer[2] = ttlSN[0];
            usbConnection.OutBuffer[3] = ttlSN[1];
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            lungSerialNumberDisplayLabel.Text = "S/N not read";
            DisplayUSBBufferData();
        }

        private void setReadHSSCDButton_Click(object sender, EventArgs e)
        {
            HSSCalibDialog hsscd = new HSSCalibDialog();
            hsscd.ShowDialog(this);

        }

        private void setReadLSSCDButton_Click(object sender, EventArgs e)
        {
            LSSCalibDialog lsscd = new LSSCalibDialog();
            lsscd.ShowDialog(this);

        }

        private void setHWVersionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.SET_HARDWARE_VERSION;
            usbConnection.OutBuffer[1] = (byte)cmd;
            byte hwVerMaj = Convert.ToByte(hwVerMajTextBox.Text);
            byte hwVerMin = Convert.ToByte(hwVerMinTextBox.Text);
            usbConnection.OutBuffer[2] = hwVerMaj;
            usbConnection.OutBuffer[3] = hwVerMin;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            hwVersionDisplayLabel.Text = string.Format("v{0:X3}.{1:X3}", hwVerMaj, hwVerMin);
            DisplayUSBBufferData();

        }

        private void readHWVersionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_HARDWARE_VERSION;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            byte hwVerMaj = usbConnection.InBuffer[2];
            byte hwVerMin = usbConnection.InBuffer[3];
            hwVersionDisplayLabel.Text = string.Format("v{0:X3}.{1:X3}", hwVerMaj, hwVerMin);
            hwVerMajTextBox.Text = hwVerMaj.ToString();
            hwVerMinTextBox.Text = hwVerMin.ToString();
            DisplayUSBBufferData();

        }

        private void readSWVersionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_FIRMWARE_VERSION;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            byte swVerMaj = usbConnection.InBuffer[2];
            byte swVerMin = usbConnection.InBuffer[3];
            swVersionDisplayLabel.Text = string.Format("v{0:X3}.{1:X3}", swVerMaj, swVerMin);
            DisplayUSBBufferData();

        }

        private void setReadComplianceCalibrationDataButton_Click(object sender, EventArgs e)
        {

            CompCalibDialog ccd = new CompCalibDialog();
            ccd.ShowDialog(this);

        }

        private void testHighSpeedDataRateButton_Click(object sender, EventArgs e)
        {
            Int64 minTicks = Int64.MaxValue;
            Int64 maxTicks = Int64.MinValue;
            Int64 ticks = 0;
            Int64 totalTicks = 0;

            Debug.WriteLine("Testing HID USB HS data rate");
            Console.WriteLine("Testing HID USB HS data rate:");
            Console.WriteLine("Timer Frequency: {0} ticks/second", Stopwatch.Frequency);
            Console.WriteLine("Running test, please wait...");

            cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < HSDP_SAMPLES; ++i)
            {
                stopwatch.Restart();
                usbConnection.sendViaUSB();
                usbConnection.receiveViaUSB();
                ticks = stopwatch.ElapsedTicks;
                if (ticks < minTicks)
                {
                    minTicks = ticks;
                }
                if (ticks > maxTicks)
                {
                    maxTicks = ticks;
                }
                totalTicks += ticks;
            }
            Console.WriteLine("Minimum interval between packets: {0:F3} us", (double)minTicks * 1000000.0 / (double)Stopwatch.Frequency);
            Console.WriteLine("Average interval between packets: {0:F3} us", (double)totalTicks * 1000000.0 / (double)HSDP_SAMPLES / (double)Stopwatch.Frequency);
            Console.WriteLine("Maximum interval between packets: {0:F3} us", (double)maxTicks * 1000000.0 / (double)Stopwatch.Frequency);
        }

        #endregion Factory panel event handlers


        private void usbCommTimer_Tick(object sender, EventArgs e)
        {
            byte packetNum = 0;
            byte nextPacketNum = 0;
            long avgPackageInterval = 0;
            long maxPackageInterval = 0;

            cmd = PV3DataTypes.PV3CommandType.RD_POT;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();

            if (FactoryControlPanel.Visible == true)
            {
                AUXINValue = (uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2];
                auxinBarDisplayLabel.Text = AUXINValue.ToString();
                potProgressBar.Value = (int)AUXINValue;
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            
            int sampleSetsInPacket = usbConnection.InBuffer[3];

            while (sampleSetsInPacket > 0)
            {
                for (int i = 0; i < sampleSetsInPacket; ++i)
                {
                    if (i == 0)
                    {
                        pv3Data.PPROXRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
                        pv3Data.PLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);
                        pv3Data.PRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[9] << 8) + (uint)usbConnection.InBuffer[8]);
                        pv3Data.PHIGHRaw = (ushort)((uint)(usbConnection.InBuffer[11] << 8) + (uint)usbConnection.InBuffer[10]);
                        pv3Data.AUXINRaw = (ushort)((uint)(usbConnection.InBuffer[13] << 8) + (uint)usbConnection.InBuffer[12]);

                        // TODO: Smooth pressure data streams
                        // TODO: Reset missed package count when restarting data acquisition
                        // DONE: Use stopwatch to set data sample position in data stream arrays
                        // DONE: Interpolate missed samples - in progress
                        // TODO: Handle first data sample

                        long sampleNumber = dataStopwatch.ElapsedMilliseconds / 2;
                        pv3Data.AddSampleSet(sampleNumber);

                    }

                    long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                    if (elapsedMilliseconds > maxPackageInterval)
                    {
                        maxPackageInterval = elapsedMilliseconds;
                    }
                    avgPackageInterval += elapsedMilliseconds;

                    stopwatch.Restart();
                    packetNum = nextPacketNum;
                }
                
                nextPacketNum = usbConnection.InBuffer[2];
                
                if (FactoryControlPanel.Visible == true)
                {
                    if ((packetNum != 0) && (packetNum != 255))
                    {
                        packagesMissedDisplayLabel.Text = (nextPacketNum - packetNum - 1).ToString();
                    }
                    else
                    {
                        packagesMissedDisplayLabel.Text = "0";
                    }

                    packageCountDisplayLabel.Text = nextPacketNum.ToString();
                    sizeDisplayLabel.Text = sampleSetsInPacket.ToString();

                    packageIntervalDisplayLabel.Text = ((double)avgPackageInterval / sampleSetsInPacket).ToString("0.0");
                    avgPackageInterval = 0;

                }

                usbConnection.sendViaUSB();
                usbConnection.receiveViaUSB();
                sampleSetsInPacket = usbConnection.InBuffer[3];
            }

            if (FactoryControlPanel.Visible == true)
            {
                maxPackageIntervalDisplayLabel.Text = maxPackageInterval.ToString();

                ch0DisplayLabel.Text = pv3Data.PPROXRaw.ToString();
                if (pv3Data.PPROXRaw < 500)
                {
                    ch0ZeroDetectedLabel.Visible = true;
                }
                pproxDisplayLabel.Text = string.Format("{0:0.00}", pv3Data.PPROX);
                ch1DisplayLabel.Text = pv3Data.PLEFTRaw.ToString();
                pleftDisplayLabel.Text = pv3Data.PLEFT.ToString("0.00");
                ch2DisplayLabel.Text = pv3Data.PRGHTRaw.ToString();
                prghtDisplayLabel.Text = pv3Data.PRGHT.ToString("0.00");
                ch3DisplayLabel.Text = pv3Data.PHIGHRaw.ToString();
                phighDisplayLabel.Text = pv3Data.PHIGH.ToString("0.00");
                ch4DisplayLabel.Text = pv3Data.AUXINRaw.ToString();
                auxinDisplayLabel.Text = pv3Data.AUXIN.ToString("0.00");
            }


            #region Legacy display code
            //for (int i = 0; i < 10; ++i)
            //{
            //    cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            //    usbConnection.OutBuffer[1] = (byte)cmd;
            //    usbConnection.sendViaUSB();
            //    usbConnection.receiveViaUSB();

            //    if (i == 0)
            //    {
            //        pv3Data.PPROXRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
            //        ch0DisplayLabel.Text = pv3Data.PPROXRaw.ToString();
            //        if (pv3Data.PPROXRaw < 500)
            //        {
            //            ch0ZeroDetectedLabel.Visible = true;
            //        }
            //        pproxDisplayLabel.Text = string.Format("{0:0.00}", pv3Data.PPROX);
            //        pv3Data.PLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);
            //        ch1DisplayLabel.Text = pv3Data.PLEFTRaw.ToString();
            //        pleftDisplayLabel.Text = pv3Data.PLEFT.ToString("0.00");
            //        pv3Data.PRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[9] << 8) + (uint)usbConnection.InBuffer[8]);
            //        ch2DisplayLabel.Text = pv3Data.PRGHTRaw.ToString();
            //        prghtDisplayLabel.Text = pv3Data.PRGHT.ToString("0.00");
            //        pv3Data.PHIGHRaw = (ushort)((uint)(usbConnection.InBuffer[11] << 8) + (uint)usbConnection.InBuffer[10]);
            //        ch3DisplayLabel.Text = pv3Data.PHIGHRaw.ToString();
            //        phighDisplayLabel.Text = pv3Data.PHIGH.ToString("0.00");
            //        pv3Data.AUXINRaw = (ushort)((uint)(usbConnection.InBuffer[13] << 8) + (uint)usbConnection.InBuffer[12]);
            //        ch4DisplayLabel.Text = pv3Data.AUXINRaw.ToString();
            //        auxinDisplayLabel.Text = pv3Data.AUXIN.ToString("0.00");
            //    }

            //    nextPacketNum = usbConnection.InBuffer[2];
            //    if ((packetNum != 0) && (packetNum != 255))
            //    {
            //        packagesMissedDisplayLabel.Text = (nextPacketNum - packetNum - 1).ToString();
            //    }
            //    long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            //    if (i != 0)
            //    {
            //        packageCountDisplayLabel.Text = usbConnection.InBuffer[2].ToString();
            //        sizeDisplayLabel.Text = usbConnection.InBuffer[3].ToString();
            //        if (elapsedMilliseconds > maxPackageInterval)
            //        {
            //            maxPackageInterval = elapsedMilliseconds;
            //        }
            //        avgPackageInterval += elapsedMilliseconds;
            //    }
            //    stopwatch.Restart();
            //    packetNum = nextPacketNum;
            //}
            //packageIntervalDisplayLabel.Text = ((double)avgPackageInterval / 9.0).ToString("0.0");
            //maxPackageIntervalDisplayLabel.Text = maxPackageInterval.ToString();
            #endregion Legacy display code

            cmd = PV3DataTypes.PV3CommandType.RD_LSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();

            pv3Data.TLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2]);
            pv3Data.TRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
            pv3Data.FiO2Raw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);

            if (FactoryControlPanel.Visible == true)
            {
                lltRawDisplayLabel.Text = pv3Data.TLEFTRaw.ToString("X4");
                leftLungTemperatureDisplayLabel.Text = pv3Data.TLEFT.ToString("0.000");
                rltRawDisplayLabel.Text = pv3Data.TRGHTRaw.ToString("X4");
                rightLungTemperatureDisplayLabel.Text = pv3Data.TRGHT.ToString("0.000");
                fio2RawDisplayLabel.Text = pv3Data.FiO2Raw.ToString("X4");
                fio2DisplayLabel.Text = pv3Data.FiO2.ToString("0.0");
            }

            cumulativeSavedDataTimeDisplayLabel.Text = (dataStopwatch.ElapsedMilliseconds / 1000.0).ToString("0.000");

            // Update plots:
            if ((dataStopwatch.ElapsedMilliseconds % 100L) == 0)
            {
                PressuresPlot.Render();
                VolumeFlowPlot.Render();
            }

        }

        #region Data capture and plotting event handlers

        private void ZeroAllButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();

            usbConnection.receiveViaUSB();
            pv3Data.PPROXRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
            pv3Data.PPROXZero = pv3Data.PPROXRaw;
            pv3Data.PLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);
            pv3Data.PLEFTZero = pv3Data.PLEFTRaw;
            pv3Data.PRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[9] << 8) + (uint)usbConnection.InBuffer[8]);
            pv3Data.PRGHTZero = pv3Data.PRGHTRaw;
            pv3Data.PHIGHRaw = (ushort)((uint)(usbConnection.InBuffer[11] << 8) + (uint)usbConnection.InBuffer[10]);
            pv3Data.PHIGHZero = pv3Data.PHIGHRaw;
            pv3Data.AUXINRaw = (ushort)((uint)(usbConnection.InBuffer[13] << 8) + (uint)usbConnection.InBuffer[12]);
            pv3Data.AUXINZero = pv3Data.AUXINRaw;

        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            for (long i = 0; i < HSDP_SAMPLES; ++i)
            {
                pv3Data.airwayPressureStream[i] = 0.0;
                pv3Data.leftLungPressureStream[i] = 0.0;
                pv3Data.rightLungPressureStream[i] = 0.0;
                pv3Data.leftVolumeStream[i] = 0.0;
                pv3Data.rightVolumeStream[i] = 0.0;
                pv3Data.volumeStream[i] = 0.0;
                pv3Data.leftFlowStream[i] = 0.0;
                pv3Data.rightFlowStream[i] = 0.0;
                pv3Data.flowStream[i] = 0.0;

            }

            PressuresPlot.Render();
            VolumeFlowPlot.Render();

            dataStopwatch.Restart();
            cumulativeSavedDataTimeDisplayLabel.Text = (dataStopwatch.ElapsedMilliseconds / 1000.0).ToString("0.000");

        }

        private void startDataAcquisitionButton_Click(object sender, EventArgs e)
        {
            if (usbCommTimer.Enabled == false)
            {
                // Start data acquisition:
                cmd = PV3DataTypes.PV3CommandType.START_DATA_ACQ;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
                usbConnection.receiveViaUSB();
                DisplayUSBBufferData();
                usbCommTimer.Enabled = true;
                //PlotTimer.Enabled = true;
                dataStopwatch.Start();

                // Change button text & appearence to indicate data acquisition is in progress:
                StartStopDataAcquisitionButton.Text = "End Data Acquisition";

            }
            else
            {
                // End data acquisition:
                cmd = PV3DataTypes.PV3CommandType.STOP_DATA_ACQ;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
                usbConnection.receiveViaUSB();
                DisplayUSBBufferData();
                usbCommTimer.Enabled = false;
                //PlotTimer.Enabled = false;
                dataStopwatch.Stop();

                // Change button text & appearence to indicate data acquisition can be started:
                StartStopDataAcquisitionButton.Text = "Start Data Acquisition";

                // Prompt user to save captured data:

            }
        }

        private void showAllPressuresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            leftLungPressureSignal.IsVisible = showAllPressuresCheckBox.Checked;
            rightLungPressureSignal.IsVisible = showAllPressuresCheckBox.Checked;

            PressuresPlot.Render();
        }

        private void showAllVolumesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            leftVolumeSignal.IsVisible = showAllVolumesCheckBox.Checked;
            rightVolumeSignal.IsVisible = showAllVolumesCheckBox.Checked;

            VolumeFlowPlot.Render();
        }

        private void SaveDataSegmentButton_Click(object sender, EventArgs e)
        {
            String filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save data segment",
                FileName = filename,
                DefaultExt = "csv",
                Filter = "Comma-separated values (*.csv)|*.csv",
                //CheckPathExists = true,
                CheckFileExists = false,
                OverwritePrompt = true,

            };

            DialogResult dlgResult = saveFileDialog.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                // Create file and save data:
                try
                {
                    double dataTime = 0;
                    using (CSVFileWriter writer = new CSVFileWriter(saveFileDialog.FileName))
                    {
                        CSVRow header = new CSVRow();
                        header.Add("Time");
                        header.Add("PProx");
                        header.Add("PLeft");
                        header.Add("PRight");
                        header.Add("Volume");
                        header.Add("Flow");
                        header.Add("LVolume");
                        header.Add("RVolume");
                        header.Add("LFlow");
                        header.Add("RFlow");

                        writer.WriteRow(header);

                        for (UInt32 i = 0; i < pv3Data.airwayPressureStream.Length; ++i)
                        {
                            CSVRow row = new CSVRow();
                            row.Add(dataTime.ToString("0.000"));
                            row.Add(pv3Data.airwayPressureStream[i].ToString());
                            row.Add(pv3Data.leftLungPressureStream[i].ToString());
                            row.Add(pv3Data.rightLungPressureStream[i].ToString());
                            row.Add(pv3Data.volumeStream[i].ToString());
                            row.Add(pv3Data.flowStream[i].ToString());
                            row.Add(pv3Data.leftVolumeStream[i].ToString());
                            row.Add(pv3Data.rightVolumeStream[i].ToString());
                            row.Add(pv3Data.leftFlowStream[i].ToString());
                            row.Add(pv3Data.rightFlowStream[i].ToString());

                            writer.WriteRow(row);
                            dataTime += 0.002;
                        }
                        writer.Flush();
                    };
                    filename = saveFileDialog.FileName;
                    Console.WriteLine("Data saved to: {0}", filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file to disk; original error: " + ex.Message);
                }
            }
            else
            {
                filename = "";
            }

        }

        private void displayPlotsButton_Click(object sender, EventArgs e)
        {
            PlotDisplay pd = new PlotDisplay();
            pd.Show(this);
        }

        private void PlotTimer_Tick(object sender, EventArgs e)
        {
            PressuresPlot.Render();
            VolumeFlowPlot.Render();
        }


        #endregion Data capture and plotting event handlers
    }
}
