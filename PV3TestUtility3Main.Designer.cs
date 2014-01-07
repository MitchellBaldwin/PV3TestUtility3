﻿namespace PV3TestUtility3
{
    partial class PV3TestUtility3Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PV3TestUtility3Main));
            this.connectionStateLabel = new System.Windows.Forms.Label();
            this.toggleLEDsButton = new System.Windows.Forms.Button();
            this.enterBootloaderButton = new System.Windows.Forms.Button();
            this.resetMCUButton = new System.Windows.Forms.Button();
            this.potProgressBar = new System.Windows.Forms.ProgressBar();
            this.usbCommTimer = new System.Windows.Forms.Timer(this.components);
            this.auxinLabel = new System.Windows.Forms.Label();
            this.auxinBarDisplayLabel = new System.Windows.Forms.Label();
            this.ch0Label = new System.Windows.Forms.Label();
            this.ch1Label = new System.Windows.Forms.Label();
            this.ch2Label = new System.Windows.Forms.Label();
            this.ch3Label = new System.Windows.Forms.Label();
            this.ch4Label = new System.Windows.Forms.Label();
            this.ch4DisplayLabel = new System.Windows.Forms.Label();
            this.ch3DisplayLabel = new System.Windows.Forms.Label();
            this.ch2DisplayLabel = new System.Windows.Forms.Label();
            this.ch1DisplayLabel = new System.Windows.Forms.Label();
            this.ch0DisplayLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.packageCountLabel = new System.Windows.Forms.Label();
            this.sizeDisplayLabel = new System.Windows.Forms.Label();
            this.packageCountDisplayLabel = new System.Windows.Forms.Label();
            this.startDataAcquisitionButton = new System.Windows.Forms.Button();
            this.stopDataAcquisitionButton = new System.Windows.Forms.Button();
            this.lungModelLabel = new System.Windows.Forms.Label();
            this.lungSerialNumberLabel = new System.Windows.Forms.Label();
            this.lungModelTextBox = new System.Windows.Forms.TextBox();
            this.lungSerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.writeLungModelButton = new System.Windows.Forms.Button();
            this.writeLungSerialNumberButton = new System.Windows.Forms.Button();
            this.lungModelDisplayLabel = new System.Windows.Forms.Label();
            this.lungSerialNumberDisplayLabel = new System.Windows.Forms.Label();
            this.readLungSerialNumberButton = new System.Windows.Forms.Button();
            this.readLungModelButton = new System.Windows.Forms.Button();
            this.leftLungTemperatureLabel = new System.Windows.Forms.Label();
            this.rightLungTemperatureLabel = new System.Windows.Forms.Label();
            this.fio2Label = new System.Windows.Forms.Label();
            this.leftLungTemperatureDisplayLabel = new System.Windows.Forms.Label();
            this.rightLungTemperatureDisplayLabel = new System.Windows.Forms.Label();
            this.fio2DisplayLabel = new System.Windows.Forms.Label();
            this.setReadComplianceCalibrationDataButton = new System.Windows.Forms.Button();
            this.setReadHSSCDButton = new System.Windows.Forms.Button();
            this.setReadLSSCDButton = new System.Windows.Forms.Button();
            this.auxinDisplayLabel = new System.Windows.Forms.Label();
            this.phighDisplayLabel = new System.Windows.Forms.Label();
            this.prghtDisplayLabel = new System.Windows.Forms.Label();
            this.pleftDisplayLabel = new System.Windows.Forms.Label();
            this.pproxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionStateLabel
            // 
            this.connectionStateLabel.BackColor = System.Drawing.Color.Yellow;
            this.connectionStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectionStateLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStateLabel.Name = "connectionStateLabel";
            this.connectionStateLabel.Size = new System.Drawing.Size(256, 23);
            this.connectionStateLabel.TabIndex = 0;
            this.connectionStateLabel.Text = "connection state";
            this.connectionStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectionStateLabel.Click += new System.EventHandler(this.connectionStateLabel_Click);
            // 
            // toggleLEDsButton
            // 
            this.toggleLEDsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleLEDsButton.Location = new System.Drawing.Point(15, 406);
            this.toggleLEDsButton.Name = "toggleLEDsButton";
            this.toggleLEDsButton.Size = new System.Drawing.Size(105, 23);
            this.toggleLEDsButton.TabIndex = 1;
            this.toggleLEDsButton.Text = "Toggle LEDs";
            this.toggleLEDsButton.UseVisualStyleBackColor = true;
            this.toggleLEDsButton.Click += new System.EventHandler(this.toggleLEDsButton_Click);
            // 
            // enterBootloaderButton
            // 
            this.enterBootloaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBootloaderButton.Location = new System.Drawing.Point(768, 406);
            this.enterBootloaderButton.Name = "enterBootloaderButton";
            this.enterBootloaderButton.Size = new System.Drawing.Size(105, 23);
            this.enterBootloaderButton.TabIndex = 2;
            this.enterBootloaderButton.Text = "Enter Bootloader";
            this.enterBootloaderButton.UseVisualStyleBackColor = true;
            this.enterBootloaderButton.Click += new System.EventHandler(this.enterBootloaderButton_Click);
            // 
            // resetMCUButton
            // 
            this.resetMCUButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMCUButton.Location = new System.Drawing.Point(879, 406);
            this.resetMCUButton.Name = "resetMCUButton";
            this.resetMCUButton.Size = new System.Drawing.Size(105, 23);
            this.resetMCUButton.TabIndex = 3;
            this.resetMCUButton.Text = "Reset MCU";
            this.resetMCUButton.UseVisualStyleBackColor = true;
            this.resetMCUButton.Click += new System.EventHandler(this.resetMCUButton_Click);
            // 
            // potProgressBar
            // 
            this.potProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.potProgressBar.BackColor = System.Drawing.Color.Black;
            this.potProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.potProgressBar.Location = new System.Drawing.Point(289, 406);
            this.potProgressBar.Maximum = 4095;
            this.potProgressBar.Name = "potProgressBar";
            this.potProgressBar.Size = new System.Drawing.Size(393, 23);
            this.potProgressBar.Step = 1;
            this.potProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.potProgressBar.TabIndex = 4;
            // 
            // usbCommTimer
            // 
            this.usbCommTimer.Tick += new System.EventHandler(this.usbCommTimer_Tick);
            // 
            // auxinLabel
            // 
            this.auxinLabel.AutoSize = true;
            this.auxinLabel.Location = new System.Drawing.Point(186, 411);
            this.auxinLabel.Name = "auxinLabel";
            this.auxinLabel.Size = new System.Drawing.Size(46, 13);
            this.auxinLabel.TabIndex = 5;
            this.auxinLabel.Text = "AUX IN:";
            // 
            // auxinBarDisplayLabel
            // 
            this.auxinBarDisplayLabel.Location = new System.Drawing.Point(238, 411);
            this.auxinBarDisplayLabel.Name = "auxinBarDisplayLabel";
            this.auxinBarDisplayLabel.Size = new System.Drawing.Size(45, 13);
            this.auxinBarDisplayLabel.TabIndex = 6;
            this.auxinBarDisplayLabel.Text = "0";
            this.auxinBarDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch0Label
            // 
            this.ch0Label.AutoSize = true;
            this.ch0Label.Location = new System.Drawing.Point(12, 204);
            this.ch0Label.Name = "ch0Label";
            this.ch0Label.Size = new System.Drawing.Size(47, 13);
            this.ch0Label.TabIndex = 7;
            this.ch0Label.Text = "PPROX:";
            // 
            // ch1Label
            // 
            this.ch1Label.AutoSize = true;
            this.ch1Label.Location = new System.Drawing.Point(12, 228);
            this.ch1Label.Name = "ch1Label";
            this.ch1Label.Size = new System.Drawing.Size(43, 13);
            this.ch1Label.TabIndex = 8;
            this.ch1Label.Text = "PLEFT:";
            // 
            // ch2Label
            // 
            this.ch2Label.AutoSize = true;
            this.ch2Label.Location = new System.Drawing.Point(12, 252);
            this.ch2Label.Name = "ch2Label";
            this.ch2Label.Size = new System.Drawing.Size(48, 13);
            this.ch2Label.TabIndex = 9;
            this.ch2Label.Text = "PRGHT:";
            // 
            // ch3Label
            // 
            this.ch3Label.AutoSize = true;
            this.ch3Label.Location = new System.Drawing.Point(12, 276);
            this.ch3Label.Name = "ch3Label";
            this.ch3Label.Size = new System.Drawing.Size(44, 13);
            this.ch3Label.TabIndex = 10;
            this.ch3Label.Text = "PHIGH:";
            // 
            // ch4Label
            // 
            this.ch4Label.AutoSize = true;
            this.ch4Label.Location = new System.Drawing.Point(12, 300);
            this.ch4Label.Name = "ch4Label";
            this.ch4Label.Size = new System.Drawing.Size(43, 13);
            this.ch4Label.TabIndex = 11;
            this.ch4Label.Text = "AUXIN:";
            // 
            // ch4DisplayLabel
            // 
            this.ch4DisplayLabel.Location = new System.Drawing.Point(65, 300);
            this.ch4DisplayLabel.Name = "ch4DisplayLabel";
            this.ch4DisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.ch4DisplayLabel.TabIndex = 16;
            this.ch4DisplayLabel.Text = "CH4";
            this.ch4DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch3DisplayLabel
            // 
            this.ch3DisplayLabel.Location = new System.Drawing.Point(65, 276);
            this.ch3DisplayLabel.Name = "ch3DisplayLabel";
            this.ch3DisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.ch3DisplayLabel.TabIndex = 15;
            this.ch3DisplayLabel.Text = "CH3";
            this.ch3DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch2DisplayLabel
            // 
            this.ch2DisplayLabel.Location = new System.Drawing.Point(65, 252);
            this.ch2DisplayLabel.Name = "ch2DisplayLabel";
            this.ch2DisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.ch2DisplayLabel.TabIndex = 14;
            this.ch2DisplayLabel.Text = "CH2";
            this.ch2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch1DisplayLabel
            // 
            this.ch1DisplayLabel.Location = new System.Drawing.Point(65, 228);
            this.ch1DisplayLabel.Name = "ch1DisplayLabel";
            this.ch1DisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.ch1DisplayLabel.TabIndex = 13;
            this.ch1DisplayLabel.Text = "CH1";
            this.ch1DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch0DisplayLabel
            // 
            this.ch0DisplayLabel.Location = new System.Drawing.Point(65, 204);
            this.ch0DisplayLabel.Name = "ch0DisplayLabel";
            this.ch0DisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.ch0DisplayLabel.TabIndex = 12;
            this.ch0DisplayLabel.Text = "CH0";
            this.ch0DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Location = new System.Drawing.Point(286, 204);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(122, 23);
            this.sizeLabel.TabIndex = 17;
            this.sizeLabel.Text = "Size (SampleCount):";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packageCountLabel
            // 
            this.packageCountLabel.Location = new System.Drawing.Point(286, 228);
            this.packageCountLabel.Name = "packageCountLabel";
            this.packageCountLabel.Size = new System.Drawing.Size(124, 13);
            this.packageCountLabel.TabIndex = 18;
            this.packageCountLabel.Text = "Package count::";
            this.packageCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sizeDisplayLabel
            // 
            this.sizeDisplayLabel.Location = new System.Drawing.Point(416, 204);
            this.sizeDisplayLabel.Name = "sizeDisplayLabel";
            this.sizeDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.sizeDisplayLabel.TabIndex = 19;
            this.sizeDisplayLabel.Text = "0";
            this.sizeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packageCountDisplayLabel
            // 
            this.packageCountDisplayLabel.Location = new System.Drawing.Point(416, 228);
            this.packageCountDisplayLabel.Name = "packageCountDisplayLabel";
            this.packageCountDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.packageCountDisplayLabel.TabIndex = 20;
            this.packageCountDisplayLabel.Text = "0";
            this.packageCountDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startDataAcquisitionButton
            // 
            this.startDataAcquisitionButton.Location = new System.Drawing.Point(12, 70);
            this.startDataAcquisitionButton.Name = "startDataAcquisitionButton";
            this.startDataAcquisitionButton.Size = new System.Drawing.Size(146, 23);
            this.startDataAcquisitionButton.TabIndex = 21;
            this.startDataAcquisitionButton.Text = "Start Data Acquisition";
            this.startDataAcquisitionButton.UseVisualStyleBackColor = true;
            this.startDataAcquisitionButton.Click += new System.EventHandler(this.startDataAcquisitionButton_Click);
            // 
            // stopDataAcquisitionButton
            // 
            this.stopDataAcquisitionButton.Location = new System.Drawing.Point(12, 99);
            this.stopDataAcquisitionButton.Name = "stopDataAcquisitionButton";
            this.stopDataAcquisitionButton.Size = new System.Drawing.Size(146, 23);
            this.stopDataAcquisitionButton.TabIndex = 22;
            this.stopDataAcquisitionButton.Text = "Stop Data Acquisition";
            this.stopDataAcquisitionButton.UseVisualStyleBackColor = true;
            this.stopDataAcquisitionButton.Click += new System.EventHandler(this.stopDataAcquisitionButton_Click);
            // 
            // lungModelLabel
            // 
            this.lungModelLabel.Location = new System.Drawing.Point(208, 75);
            this.lungModelLabel.Name = "lungModelLabel";
            this.lungModelLabel.Size = new System.Drawing.Size(105, 13);
            this.lungModelLabel.TabIndex = 23;
            this.lungModelLabel.Text = "Lung Model:";
            this.lungModelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lungSerialNumberLabel
            // 
            this.lungSerialNumberLabel.Location = new System.Drawing.Point(208, 104);
            this.lungSerialNumberLabel.Name = "lungSerialNumberLabel";
            this.lungSerialNumberLabel.Size = new System.Drawing.Size(105, 13);
            this.lungSerialNumberLabel.TabIndex = 24;
            this.lungSerialNumberLabel.Text = "Lung Serial Number:";
            this.lungSerialNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lungModelTextBox
            // 
            this.lungModelTextBox.Location = new System.Drawing.Point(319, 72);
            this.lungModelTextBox.Name = "lungModelTextBox";
            this.lungModelTextBox.Size = new System.Drawing.Size(57, 20);
            this.lungModelTextBox.TabIndex = 25;
            // 
            // lungSerialNumberTextBox
            // 
            this.lungSerialNumberTextBox.Location = new System.Drawing.Point(319, 101);
            this.lungSerialNumberTextBox.Name = "lungSerialNumberTextBox";
            this.lungSerialNumberTextBox.Size = new System.Drawing.Size(57, 20);
            this.lungSerialNumberTextBox.TabIndex = 26;
            // 
            // writeLungModelButton
            // 
            this.writeLungModelButton.Location = new System.Drawing.Point(382, 70);
            this.writeLungModelButton.Name = "writeLungModelButton";
            this.writeLungModelButton.Size = new System.Drawing.Size(146, 23);
            this.writeLungModelButton.TabIndex = 27;
            this.writeLungModelButton.Text = "Set Lung Model";
            this.writeLungModelButton.UseVisualStyleBackColor = true;
            this.writeLungModelButton.Click += new System.EventHandler(this.writeLungModelButton_Click);
            // 
            // writeLungSerialNumberButton
            // 
            this.writeLungSerialNumberButton.Location = new System.Drawing.Point(382, 99);
            this.writeLungSerialNumberButton.Name = "writeLungSerialNumberButton";
            this.writeLungSerialNumberButton.Size = new System.Drawing.Size(146, 23);
            this.writeLungSerialNumberButton.TabIndex = 28;
            this.writeLungSerialNumberButton.Text = "Set Lung Serial Number";
            this.writeLungSerialNumberButton.UseVisualStyleBackColor = true;
            this.writeLungSerialNumberButton.Click += new System.EventHandler(this.writeLungSerialNumberButton_Click);
            // 
            // lungModelDisplayLabel
            // 
            this.lungModelDisplayLabel.AutoSize = true;
            this.lungModelDisplayLabel.Location = new System.Drawing.Point(686, 75);
            this.lungModelDisplayLabel.Name = "lungModelDisplayLabel";
            this.lungModelDisplayLabel.Size = new System.Drawing.Size(97, 13);
            this.lungModelDisplayLabel.TabIndex = 29;
            this.lungModelDisplayLabel.Text = "Invalid Lung Model";
            // 
            // lungSerialNumberDisplayLabel
            // 
            this.lungSerialNumberDisplayLabel.AutoSize = true;
            this.lungSerialNumberDisplayLabel.Location = new System.Drawing.Point(686, 104);
            this.lungSerialNumberDisplayLabel.Name = "lungSerialNumberDisplayLabel";
            this.lungSerialNumberDisplayLabel.Size = new System.Drawing.Size(134, 13);
            this.lungSerialNumberDisplayLabel.TabIndex = 30;
            this.lungSerialNumberDisplayLabel.Text = "Invalid Lung Serial Number";
            // 
            // readLungSerialNumberButton
            // 
            this.readLungSerialNumberButton.Location = new System.Drawing.Point(534, 99);
            this.readLungSerialNumberButton.Name = "readLungSerialNumberButton";
            this.readLungSerialNumberButton.Size = new System.Drawing.Size(146, 23);
            this.readLungSerialNumberButton.TabIndex = 32;
            this.readLungSerialNumberButton.Text = "Read Lung Serial Number";
            this.readLungSerialNumberButton.UseVisualStyleBackColor = true;
            this.readLungSerialNumberButton.Click += new System.EventHandler(this.readLungSerialNumberButton_Click);
            // 
            // readLungModelButton
            // 
            this.readLungModelButton.Location = new System.Drawing.Point(534, 70);
            this.readLungModelButton.Name = "readLungModelButton";
            this.readLungModelButton.Size = new System.Drawing.Size(146, 23);
            this.readLungModelButton.TabIndex = 31;
            this.readLungModelButton.Text = "Read Lung Model";
            this.readLungModelButton.UseVisualStyleBackColor = true;
            this.readLungModelButton.Click += new System.EventHandler(this.readLungModelButton_Click);
            // 
            // leftLungTemperatureLabel
            // 
            this.leftLungTemperatureLabel.Location = new System.Drawing.Point(534, 204);
            this.leftLungTemperatureLabel.Name = "leftLungTemperatureLabel";
            this.leftLungTemperatureLabel.Size = new System.Drawing.Size(124, 23);
            this.leftLungTemperatureLabel.TabIndex = 33;
            this.leftLungTemperatureLabel.Text = "Left Lung Temperature";
            this.leftLungTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightLungTemperatureLabel
            // 
            this.rightLungTemperatureLabel.Location = new System.Drawing.Point(534, 227);
            this.rightLungTemperatureLabel.Name = "rightLungTemperatureLabel";
            this.rightLungTemperatureLabel.Size = new System.Drawing.Size(124, 23);
            this.rightLungTemperatureLabel.TabIndex = 34;
            this.rightLungTemperatureLabel.Text = "Right Lung Temperature";
            this.rightLungTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fio2Label
            // 
            this.fio2Label.Location = new System.Drawing.Point(534, 252);
            this.fio2Label.Name = "fio2Label";
            this.fio2Label.Size = new System.Drawing.Size(124, 23);
            this.fio2Label.TabIndex = 35;
            this.fio2Label.Text = "FiO2";
            this.fio2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leftLungTemperatureDisplayLabel
            // 
            this.leftLungTemperatureDisplayLabel.Location = new System.Drawing.Point(664, 204);
            this.leftLungTemperatureDisplayLabel.Name = "leftLungTemperatureDisplayLabel";
            this.leftLungTemperatureDisplayLabel.Size = new System.Drawing.Size(45, 13);
            this.leftLungTemperatureDisplayLabel.TabIndex = 36;
            this.leftLungTemperatureDisplayLabel.Text = "20";
            this.leftLungTemperatureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightLungTemperatureDisplayLabel
            // 
            this.rightLungTemperatureDisplayLabel.Location = new System.Drawing.Point(664, 227);
            this.rightLungTemperatureDisplayLabel.Name = "rightLungTemperatureDisplayLabel";
            this.rightLungTemperatureDisplayLabel.Size = new System.Drawing.Size(45, 13);
            this.rightLungTemperatureDisplayLabel.TabIndex = 37;
            this.rightLungTemperatureDisplayLabel.Text = "20";
            this.rightLungTemperatureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fio2DisplayLabel
            // 
            this.fio2DisplayLabel.Location = new System.Drawing.Point(664, 252);
            this.fio2DisplayLabel.Name = "fio2DisplayLabel";
            this.fio2DisplayLabel.Size = new System.Drawing.Size(45, 13);
            this.fio2DisplayLabel.TabIndex = 38;
            this.fio2DisplayLabel.Text = "21";
            this.fio2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // setReadComplianceCalibrationDataButton
            // 
            this.setReadComplianceCalibrationDataButton.Location = new System.Drawing.Point(838, 70);
            this.setReadComplianceCalibrationDataButton.Name = "setReadComplianceCalibrationDataButton";
            this.setReadComplianceCalibrationDataButton.Size = new System.Drawing.Size(146, 47);
            this.setReadComplianceCalibrationDataButton.TabIndex = 39;
            this.setReadComplianceCalibrationDataButton.Text = "Set / Read Compliance Calibration Data";
            this.setReadComplianceCalibrationDataButton.UseVisualStyleBackColor = true;
            // 
            // setReadHSSCDButton
            // 
            this.setReadHSSCDButton.Location = new System.Drawing.Point(12, 169);
            this.setReadHSSCDButton.Name = "setReadHSSCDButton";
            this.setReadHSSCDButton.Size = new System.Drawing.Size(271, 23);
            this.setReadHSSCDButton.TabIndex = 40;
            this.setReadHSSCDButton.Text = "Set / Read High Speed Calibration Data";
            this.setReadHSSCDButton.UseVisualStyleBackColor = true;
            this.setReadHSSCDButton.Click += new System.EventHandler(this.setReadHSSCDButton_Click);
            // 
            // setReadLSSCDButton
            // 
            this.setReadLSSCDButton.Location = new System.Drawing.Point(512, 169);
            this.setReadLSSCDButton.Name = "setReadLSSCDButton";
            this.setReadLSSCDButton.Size = new System.Drawing.Size(209, 23);
            this.setReadLSSCDButton.TabIndex = 41;
            this.setReadLSSCDButton.Text = "Set / Read Low Speed Calibration Data";
            this.setReadLSSCDButton.UseVisualStyleBackColor = true;
            this.setReadLSSCDButton.Click += new System.EventHandler(this.setReadLSSCDButton_Click);
            // 
            // auxinDisplayLabel
            // 
            this.auxinDisplayLabel.Location = new System.Drawing.Point(126, 300);
            this.auxinDisplayLabel.Name = "auxinDisplayLabel";
            this.auxinDisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.auxinDisplayLabel.TabIndex = 46;
            this.auxinDisplayLabel.Text = "0.00";
            this.auxinDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phighDisplayLabel
            // 
            this.phighDisplayLabel.Location = new System.Drawing.Point(126, 276);
            this.phighDisplayLabel.Name = "phighDisplayLabel";
            this.phighDisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.phighDisplayLabel.TabIndex = 45;
            this.phighDisplayLabel.Text = "0.00";
            this.phighDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prghtDisplayLabel
            // 
            this.prghtDisplayLabel.Location = new System.Drawing.Point(126, 252);
            this.prghtDisplayLabel.Name = "prghtDisplayLabel";
            this.prghtDisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.prghtDisplayLabel.TabIndex = 44;
            this.prghtDisplayLabel.Text = "0.00";
            this.prghtDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pleftDisplayLabel
            // 
            this.pleftDisplayLabel.Location = new System.Drawing.Point(126, 228);
            this.pleftDisplayLabel.Name = "pleftDisplayLabel";
            this.pleftDisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.pleftDisplayLabel.TabIndex = 43;
            this.pleftDisplayLabel.Text = "0.00";
            this.pleftDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pproxDisplayLabel
            // 
            this.pproxDisplayLabel.Location = new System.Drawing.Point(126, 204);
            this.pproxDisplayLabel.Name = "pproxDisplayLabel";
            this.pproxDisplayLabel.Size = new System.Drawing.Size(55, 13);
            this.pproxDisplayLabel.TabIndex = 42;
            this.pproxDisplayLabel.Text = "0.00";
            this.pproxDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PV3TestUtility3Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 441);
            this.Controls.Add(this.auxinDisplayLabel);
            this.Controls.Add(this.phighDisplayLabel);
            this.Controls.Add(this.prghtDisplayLabel);
            this.Controls.Add(this.pleftDisplayLabel);
            this.Controls.Add(this.pproxDisplayLabel);
            this.Controls.Add(this.setReadLSSCDButton);
            this.Controls.Add(this.setReadHSSCDButton);
            this.Controls.Add(this.setReadComplianceCalibrationDataButton);
            this.Controls.Add(this.fio2DisplayLabel);
            this.Controls.Add(this.rightLungTemperatureDisplayLabel);
            this.Controls.Add(this.leftLungTemperatureDisplayLabel);
            this.Controls.Add(this.fio2Label);
            this.Controls.Add(this.rightLungTemperatureLabel);
            this.Controls.Add(this.leftLungTemperatureLabel);
            this.Controls.Add(this.readLungSerialNumberButton);
            this.Controls.Add(this.readLungModelButton);
            this.Controls.Add(this.lungSerialNumberDisplayLabel);
            this.Controls.Add(this.lungModelDisplayLabel);
            this.Controls.Add(this.writeLungSerialNumberButton);
            this.Controls.Add(this.writeLungModelButton);
            this.Controls.Add(this.lungSerialNumberTextBox);
            this.Controls.Add(this.lungModelTextBox);
            this.Controls.Add(this.lungSerialNumberLabel);
            this.Controls.Add(this.lungModelLabel);
            this.Controls.Add(this.stopDataAcquisitionButton);
            this.Controls.Add(this.startDataAcquisitionButton);
            this.Controls.Add(this.packageCountDisplayLabel);
            this.Controls.Add(this.sizeDisplayLabel);
            this.Controls.Add(this.packageCountLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.ch4DisplayLabel);
            this.Controls.Add(this.ch3DisplayLabel);
            this.Controls.Add(this.ch2DisplayLabel);
            this.Controls.Add(this.ch1DisplayLabel);
            this.Controls.Add(this.ch0DisplayLabel);
            this.Controls.Add(this.ch4Label);
            this.Controls.Add(this.ch3Label);
            this.Controls.Add(this.ch2Label);
            this.Controls.Add(this.ch1Label);
            this.Controls.Add(this.ch0Label);
            this.Controls.Add(this.auxinBarDisplayLabel);
            this.Controls.Add(this.auxinLabel);
            this.Controls.Add(this.potProgressBar);
            this.Controls.Add(this.resetMCUButton);
            this.Controls.Add(this.enterBootloaderButton);
            this.Controls.Add(this.toggleLEDsButton);
            this.Controls.Add(this.connectionStateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PV3TestUtility3Main";
            this.Text = "PneuView 3 Test Utility v3.0";
            this.Load += new System.EventHandler(this.PV3TestUtility3Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectionStateLabel;
        private System.Windows.Forms.Button toggleLEDsButton;
        private System.Windows.Forms.Button enterBootloaderButton;
        private System.Windows.Forms.Button resetMCUButton;
        private System.Windows.Forms.ProgressBar potProgressBar;
        private System.Windows.Forms.Timer usbCommTimer;
        private System.Windows.Forms.Label auxinLabel;
        private System.Windows.Forms.Label auxinBarDisplayLabel;
        private System.Windows.Forms.Label ch0Label;
        private System.Windows.Forms.Label ch1Label;
        private System.Windows.Forms.Label ch2Label;
        private System.Windows.Forms.Label ch3Label;
        private System.Windows.Forms.Label ch4Label;
        private System.Windows.Forms.Label ch4DisplayLabel;
        private System.Windows.Forms.Label ch3DisplayLabel;
        private System.Windows.Forms.Label ch2DisplayLabel;
        private System.Windows.Forms.Label ch1DisplayLabel;
        private System.Windows.Forms.Label ch0DisplayLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label packageCountLabel;
        private System.Windows.Forms.Label sizeDisplayLabel;
        private System.Windows.Forms.Label packageCountDisplayLabel;
        private System.Windows.Forms.Button startDataAcquisitionButton;
        private System.Windows.Forms.Button stopDataAcquisitionButton;
        private System.Windows.Forms.Label lungModelLabel;
        private System.Windows.Forms.Label lungSerialNumberLabel;
        private System.Windows.Forms.TextBox lungModelTextBox;
        private System.Windows.Forms.TextBox lungSerialNumberTextBox;
        private System.Windows.Forms.Button writeLungModelButton;
        private System.Windows.Forms.Button writeLungSerialNumberButton;
        private System.Windows.Forms.Label lungModelDisplayLabel;
        private System.Windows.Forms.Label lungSerialNumberDisplayLabel;
        private System.Windows.Forms.Button readLungSerialNumberButton;
        private System.Windows.Forms.Button readLungModelButton;
        private System.Windows.Forms.Label leftLungTemperatureLabel;
        private System.Windows.Forms.Label rightLungTemperatureLabel;
        private System.Windows.Forms.Label fio2Label;
        private System.Windows.Forms.Label leftLungTemperatureDisplayLabel;
        private System.Windows.Forms.Label rightLungTemperatureDisplayLabel;
        private System.Windows.Forms.Label fio2DisplayLabel;
        private System.Windows.Forms.Button setReadComplianceCalibrationDataButton;
        private System.Windows.Forms.Button setReadHSSCDButton;
        private System.Windows.Forms.Button setReadLSSCDButton;
        private System.Windows.Forms.Label auxinDisplayLabel;
        private System.Windows.Forms.Label phighDisplayLabel;
        private System.Windows.Forms.Label prghtDisplayLabel;
        private System.Windows.Forms.Label pleftDisplayLabel;
        private System.Windows.Forms.Label pproxDisplayLabel;
    }
}
