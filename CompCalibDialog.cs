using System;
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
    public partial class CompCalibDialog : Form
    {
        PV3TestUtility3Main pv3tu3Main;
        USBClass pv3Connection;
        PV3DataTypes pv3Data;
        PV3DataTypes.PV3CommandType cmd;

        byte currentCompliance = 0x01;

        byte[] byteGain = new byte[2];

        public CompCalibDialog()
        {
            InitializeComponent();
        }

        private void CompCalibDialog_Load(object sender, EventArgs e)
        {
            pv3tu3Main = (PV3TestUtility3Main)Owner;
            pv3Connection = pv3tu3Main.USBConnection;
            pv3Data = pv3tu3Main.PV3Data;

            if (pv3Connection.connectionState == USBClass.CONNECTION_SUCCESSFUL)
            {
                connectionErrorLabel.Visible = false;
                foreach (Control button in this.Controls)
                {
                    if (button is Button && button != okButton)
                    {
                        button.Enabled = true;
                    }
                }

                // Read & display compliance coefficients:
                cmd = PV3DataTypes.PV3CommandType.RD_HSSCD;
                pv3Connection.OutBuffer[1] = (byte)cmd;
                pv3Connection.sendViaUSB();

                pv3Connection.receiveViaUSB();

                
            }
            else
            {
                connectionErrorLabel.Visible = true;
                foreach (Control button in this.Controls)
                {
                    if (button is Button && button != okButton)
                    {
                        button.Enabled = false;
                    }
                }
            }

        }

        private void writeCCDataButton_Click(object sender, EventArgs e)
        {
            double[] CC;
            CC = new double[4];

            byte command = 0xD0;

            pv3Connection.OutBuffer[1] = (byte)(command + currentCompliance);
 
            CC[0] = Convert.ToDouble(cc0TextBox.Text);
            CC[1] = Convert.ToDouble(cc1TextBox.Text);
            CC[2] = Convert.ToDouble(cc2TextBox.Text);
            CC[3] = Convert.ToDouble(cc3TextBox.Text);

            for (int i = 0; i < 4; ++i)
            {
                byte[] byteArray = BitConverter.GetBytes(CC[i]);
                for (int j = 0; j < 8; ++j)
                {
                    pv3Connection.OutBuffer[i*8 + j + 2] = byteArray[j];
                }
            }
            pv3Connection.sendViaUSB();
            pv3Connection.receiveViaUSB();
            pv3tu3Main.DisplayUSBBufferData();

        }

        private void readCCDataButton_Click(object sender, EventArgs e)
        {
            byte command = 0xE0;

            pv3Connection.OutBuffer[1] = (byte)(command + currentCompliance);

            pv3Connection.sendViaUSB();

            pv3Connection.receiveViaUSB();
            cc0DisplayLabel.Text = BitConverter.ToDouble(pv3Connection.InBuffer, 2).ToString();
            cc1DisplayLabel.Text = BitConverter.ToDouble(pv3Connection.InBuffer, 10).ToString();
            cc2DisplayLabel.Text = BitConverter.ToDouble(pv3Connection.InBuffer, 18).ToString();
            cc3DisplayLabel.Text = BitConverter.ToDouble(pv3Connection.InBuffer, 26).ToString();

            pv3tu3Main.DisplayUSBBufferData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            progCompDisplayLabel.Text = "Programming compliance setting " + ((ToolStripButton)sender).Text;
            currentCompliance = Convert.ToByte(((ToolStripButton)sender).Tag);
        }
    }
}
