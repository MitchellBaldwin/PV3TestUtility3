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

        // Constructor
        public PV3TestUtility3Main()
        {
            InitializeComponent();
            usbConnection = new USBClass();
            usbConnection.deviceID = "Vid_04D8&Pid_FCB6";
            blConnection = new USBClass();
            blConnection.deviceID = "Vid_04D8&Pid_003C";
        }

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

        // Connect to PV3 embedded system over USB
        public bool ConnectToUSB()
        {
            System.Threading.Thread.Sleep(500);
            usbConnection.connectionState = usbConnection.attemptUSBConnection();
            if (usbConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                connectionStateLabel.BackColor = Color.LimeGreen;
                connectionStateLabel.Text = "Connected to: " + usbConnection.deviceID;
                usbCommTimer.Enabled = true;

                // Configure the form controls for a connected device:


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

        private void PV3TestUtility3Main_Load(object sender, EventArgs e)
        {
            if (usbConnection.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL || blConnection.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL)
            {
                ConnectToUSB();
            }
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

        private void startDataAcquisitionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.START_DATA_ACQ;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            DisplayUSBBufferData();
        }

        private void stopDataAcquisitionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.STOP_DATA_ACQ;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            usbConnection.receiveViaUSB();
            DisplayUSBBufferData();
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

        private void usbCommTimer_Tick(object sender, EventArgs e)
        {
            byte packetNum = 0;
            byte nextPacketNum = 0;
            long avgPackageInterval = 0;
            long maxPackageInterval = 0;

            cmd = PV3DataTypes.PV3CommandType.RD_POT;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            //System.Threading.Thread.Sleep(10);

            usbConnection.receiveViaUSB();
            
            AUXINValue = (uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2];
            auxinBarDisplayLabel.Text = AUXINValue.ToString();
            potProgressBar.Value = (int)AUXINValue;

            Stopwatch stopwatch = Stopwatch.StartNew();
            
            //cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            //usbConnection.OutBuffer[1] = (byte)cmd;
            //usbConnection.sendViaUSB();
            //usbConnection.receiveViaUSB();

            //while (usbConnection.InBuffer[3] > 0)
            //{

            //    usbConnection.sendViaUSB();
            //    usbConnection.receiveViaUSB();
            //}

            for (int i = 0; i < 10; ++i)
            {
                cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
                usbConnection.receiveViaUSB();

                if (i == 0)
                {
                    pv3Data.PPROXRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
                    ch0DisplayLabel.Text = pv3Data.PPROXRaw.ToString();
                    if (pv3Data.PPROXRaw < 500)
                    {
                        ch0ZeroDetectedLabel.Visible = true;
                    }
                    pproxDisplayLabel.Text = string.Format("{0:0.00}", pv3Data.PPROX);
                    pv3Data.PLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);
                    ch1DisplayLabel.Text = pv3Data.PLEFTRaw.ToString();
                    pleftDisplayLabel.Text = pv3Data.PLEFT.ToString("0.00");
                    pv3Data.PRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[9] << 8) + (uint)usbConnection.InBuffer[8]);
                    ch2DisplayLabel.Text = pv3Data.PRGHTRaw.ToString();
                    prghtDisplayLabel.Text = pv3Data.PRGHT.ToString("0.00");
                    pv3Data.PHIGHRaw = (ushort)((uint)(usbConnection.InBuffer[11] << 8) + (uint)usbConnection.InBuffer[10]);
                    ch3DisplayLabel.Text = pv3Data.PHIGHRaw.ToString();
                    phighDisplayLabel.Text = pv3Data.PHIGH.ToString("0.00");
                    pv3Data.AUXINRaw = (ushort)((uint)(usbConnection.InBuffer[13] << 8) + (uint)usbConnection.InBuffer[12]);
                    ch4DisplayLabel.Text = pv3Data.AUXINRaw.ToString();
                    auxinDisplayLabel.Text = pv3Data.AUXIN.ToString("0.00");
                }
                
                nextPacketNum = usbConnection.InBuffer[2];
                if ((packetNum != 0) && (packetNum != 255))
                {
                    packagesMissedDisplayLabel.Text = (nextPacketNum - packetNum - 1).ToString();
                }
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                
                if (i != 0)
                {
                    packageCountDisplayLabel.Text = usbConnection.InBuffer[2].ToString();
                    sizeDisplayLabel.Text = usbConnection.InBuffer[3].ToString();
                    if (elapsedMilliseconds > maxPackageInterval)
                    {
                        maxPackageInterval = elapsedMilliseconds;
                    }
                    avgPackageInterval += elapsedMilliseconds;
                }
                stopwatch.Restart();
                packetNum = nextPacketNum;
            }
            packageIntervalDisplayLabel.Text = ((double)avgPackageInterval / 9.0).ToString("0.0");
            maxPackageIntervalDisplayLabel.Text = maxPackageInterval.ToString();

            cmd = PV3DataTypes.PV3CommandType.RD_LSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            
            usbConnection.receiveViaUSB();
            pv3Data.TLEFTRaw = (ushort)((uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2]);
            lltRawDisplayLabel.Text = pv3Data.TLEFTRaw.ToString("X4");
            leftLungTemperatureDisplayLabel.Text = pv3Data.TLEFT.ToString("0.000");
            pv3Data.TRGHTRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
            rltRawDisplayLabel.Text = pv3Data.TRGHTRaw.ToString("X4");
            rightLungTemperatureDisplayLabel.Text = pv3Data.TRGHT.ToString("0.000");
            pv3Data.FiO2Raw = (ushort)((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]);
            fio2RawDisplayLabel.Text = pv3Data.FiO2Raw.ToString("X4");
            fio2DisplayLabel.Text = pv3Data.FiO2.ToString("0.0");


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

        private void displayPlotsButton_Click(object sender, EventArgs e)
        {
            PlotDisplay pd = new PlotDisplay();
            pd.Show();
        }
    }
}
