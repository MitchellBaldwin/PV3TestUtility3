﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV3TestUtility3
{
    public partial class PV3TestUtility3Main : Form
    {
        // Member Variables

        USBClass usbConnection;
        public USBClass USBConnection
        {
            get { return usbConnection; }
            set { usbConnection = value; }
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
        internal const uint DBT_CONFIGCHANGED = 0x0018;

        // Constructor
        public PV3TestUtility3Main()
        {
            InitializeComponent();
            usbConnection = new USBClass();
        }

        //This is a callback function that gets called when a Windows message is received by the form.
        //We will receive various different types of messages, but the ones we really want to use are the WM_DEVICECHANGE messages.
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                if (((int)m.WParam == DBT_DEVICEARRIVAL) || ((int)m.WParam == DBT_DEVICEREMOVEPENDING) || ((int)m.WParam == DBT_DEVICEREMOVECOMPLETE) || ((int)m.WParam == DBT_CONFIGCHANGED))
                {
                    ConnectToUSB();
                }
            } //end of: if(m.Msg == WM_DEVICECHANGE)
            base.WndProc(ref m);
        } //end of: WndProc() function

        // Connect to PV3 embedded system over USB
        public bool ConnectToUSB()
        {
            usbConnection.connectionState = usbConnection.attemptUSBConnection();
            if (usbConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                connectionStateLabel.BackColor = Color.LimeGreen;
                connectionStateLabel.Text = "Connected to: " + usbConnection.deviceID;
                usbCommTimer.Enabled = true;

                // Configure the form controls for a connected device:


                return true;
            }
            else if (usbConnection.attemptUSBConnectionToBootloader() == USBClass.BOOTLOADER_CONNECTED)
            {
                connectionStateLabel.BackColor = Color.LightBlue;
                connectionStateLabel.Text = "Connected to: " + usbConnection.blDeviceID;
                usbCommTimer.Enabled = true;

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

        private void PV3TestUtility3Main_Load(object sender, EventArgs e)
        {
            if (usbConnection.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL)
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
        }

        private void enterBootloaderButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.BOOTLOAD;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
        }

        private void resetMCUButton_Click(object sender, EventArgs e)
        {
            if (usbConnection.connectionState == USBClass.BOOTLOADER_CONNECTED)
            {
                cmd = PV3DataTypes.PV3CommandType.RESET_FROM_BOOTLOADER;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
            }
            else if (usbConnection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                cmd = PV3DataTypes.PV3CommandType.RESET;
                usbConnection.OutBuffer[1] = (byte)cmd;
                usbConnection.sendViaUSB();
            }
        }

        private void startDataAcquisitionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.START_DATA_ACQ;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
        }

        private void stopDataAcquisitionButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.STOP_DATA_ACQ;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
        }

        private void readLungModelButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_LUNG_MODEL;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            
            usbConnection.receiveViaUSB();
            ttlModel = usbConnection.InBuffer[2];
        }

        private void writeLungModelButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.SET_LUNG_MODEL;
            usbConnection.OutBuffer[1] = (byte)cmd;
            ttlModel = Convert.ToByte(lungModelTextBox.Text);
            usbConnection.OutBuffer[2] = ttlModel;
            usbConnection.sendViaUSB();
        }

        private void readLungSerialNumberButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_LUNG_SN;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();

            usbConnection.receiveViaUSB();
            ttlSN[0] = usbConnection.InBuffer[2];
            ttlSN[1] = usbConnection.InBuffer[3];
        }

        private void writeLungSerialNumberButton_Click(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.SET_LUNG_SN;
            usbConnection.OutBuffer[1] = (byte)cmd;
            ushort intSN = Convert.ToUInt16(lungSerialNumberTextBox.Text);
            ttlSN[1] = (byte)(intSN / 100);
            ttlSN[0] = (byte)(intSN % 100);
            usbConnection.OutBuffer[2] = ttlSN[0];
            usbConnection.OutBuffer[3] = ttlSN[1];
            usbConnection.sendViaUSB();
        }
        private void usbCommTimer_Tick(object sender, EventArgs e)
        {
            cmd = PV3DataTypes.PV3CommandType.RD_POT;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            //System.Threading.Thread.Sleep(10);

            usbConnection.receiveViaUSB();
            AUXINValue = (uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2];
            auxinBarDisplayLabel.Text = AUXINValue.ToString();
            potProgressBar.Value = (int)AUXINValue;

            cmd = PV3DataTypes.PV3CommandType.RD_HSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();

            usbConnection.receiveViaUSB();
            pv3Data.PPROXRaw = (ushort)((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]);
            ch0DisplayLabel.Text = pv3Data.PPROXRaw.ToString();
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
            packageCountDisplayLabel.Text = usbConnection.InBuffer[2].ToString();
            sizeDisplayLabel.Text = usbConnection.InBuffer[3].ToString();

            cmd = PV3DataTypes.PV3CommandType.RD_LSSDP;
            usbConnection.OutBuffer[1] = (byte)cmd;
            usbConnection.sendViaUSB();
            
            usbConnection.receiveViaUSB();
            leftLungTemperatureDisplayLabel.Text = ((uint)(usbConnection.InBuffer[3] << 8) + (uint)usbConnection.InBuffer[2]).ToString();
            rightLungTemperatureDisplayLabel.Text = ((uint)(usbConnection.InBuffer[5] << 8) + (uint)usbConnection.InBuffer[4]).ToString();
            fio2DisplayLabel.Text = ((uint)(usbConnection.InBuffer[7] << 8) + (uint)usbConnection.InBuffer[6]).ToString();


            switch (ttlModel)
            {
                case 0:
                    lungModelDisplayLabel.Text = "Model flag not read";
                    break;
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

            if ((ttlSN[0] == 0) && (ttlSN[1] == 0))
            {
                lungSerialNumberDisplayLabel.Text = "S/N not read";
            }
            else
            {
                lungSerialNumberDisplayLabel.Text = ((uint)(ttlSN[1] * 100) + ttlSN[0]).ToString();
            }

        }

        private void setReadHSSCDButton_Click(object sender, EventArgs e)
        {
            HSSCalibDialog hsscd = new HSSCalibDialog();
            hsscd.ShowDialog();

        }

        private void setReadLSSCDButton_Click(object sender, EventArgs e)
        {
            LSSCalibDialog lsscd = new LSSCalibDialog();
            lsscd.ShowDialog();

        }

    }
}