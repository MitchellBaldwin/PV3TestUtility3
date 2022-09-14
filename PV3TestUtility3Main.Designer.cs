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
            this.usbCommTimer = new System.Windows.Forms.Timer(this.components);
            this.FactoryControlsPanel = new System.Windows.Forms.Panel();
            this.toggleLEDsButton = new System.Windows.Forms.Button();
            this.toggleBlinkStatusButton = new System.Windows.Forms.Button();
            this.testHighSpeedDataRateButton = new System.Windows.Forms.Button();
            this.auxinBarDisplayLabel = new System.Windows.Forms.Label();
            this.auxinLabel = new System.Windows.Forms.Label();
            this.potProgressBar = new System.Windows.Forms.ProgressBar();
            this.enterBootloaderButton = new System.Windows.Forms.Button();
            this.resetMCUButton = new System.Windows.Forms.Button();
            this.usbInDisplayLabel = new System.Windows.Forms.Label();
            this.usbOutDisplayLabel = new System.Windows.Forms.Label();
            this.usbInLabel = new System.Windows.Forms.Label();
            this.usbOutLabel = new System.Windows.Forms.Label();
            this.connectionStateLabel = new System.Windows.Forms.Label();
            this.ch0ZeroDetectedLabel = new System.Windows.Forms.Label();
            this.maxPackageIntervalUnitsLabel = new System.Windows.Forms.Label();
            this.packageIntervalUnitsLabel = new System.Windows.Forms.Label();
            this.maxPackageIntervalDisplayLabel = new System.Windows.Forms.Label();
            this.maxPackageIntervalLabel = new System.Windows.Forms.Label();
            this.packagesMissedDisplayLabel = new System.Windows.Forms.Label();
            this.packagesMissedLabel = new System.Windows.Forms.Label();
            this.packageIntervalDisplayLabel = new System.Windows.Forms.Label();
            this.packageIntervalLabel = new System.Windows.Forms.Label();
            this.auxinDisplayLabel = new System.Windows.Forms.Label();
            this.phighDisplayLabel = new System.Windows.Forms.Label();
            this.prghtDisplayLabel = new System.Windows.Forms.Label();
            this.pleftDisplayLabel = new System.Windows.Forms.Label();
            this.pproxDisplayLabel = new System.Windows.Forms.Label();
            this.setReadHSSCDButton = new System.Windows.Forms.Button();
            this.packageCountDisplayLabel = new System.Windows.Forms.Label();
            this.sizeDisplayLabel = new System.Windows.Forms.Label();
            this.packageCountLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.ch4DisplayLabel = new System.Windows.Forms.Label();
            this.ch3DisplayLabel = new System.Windows.Forms.Label();
            this.ch2DisplayLabel = new System.Windows.Forms.Label();
            this.ch1DisplayLabel = new System.Windows.Forms.Label();
            this.ch0DisplayLabel = new System.Windows.Forms.Label();
            this.ch4Label = new System.Windows.Forms.Label();
            this.ch3Label = new System.Windows.Forms.Label();
            this.ch2Label = new System.Windows.Forms.Label();
            this.ch1Label = new System.Windows.Forms.Label();
            this.ch0Label = new System.Windows.Forms.Label();
            this.UserControlPanel = new System.Windows.Forms.Panel();
            this.cumulativeSavedDataTimeUnitsLabel = new System.Windows.Forms.Label();
            this.cumulativeSavedDataTimeDisplayLabel = new System.Windows.Forms.Label();
            this.cumulativeSavedDataTimeLabel = new System.Windows.Forms.Label();
            this.StartStopDataAcquisitionButton = new System.Windows.Forms.Button();
            this.setReadComplianceCalibrationDataButton = new System.Windows.Forms.Button();
            this.readSWVersionButton = new System.Windows.Forms.Button();
            this.swVersionDisplayLabel = new System.Windows.Forms.Label();
            this.hwVerMinTextBox = new System.Windows.Forms.TextBox();
            this.hwVerMinLabel = new System.Windows.Forms.Label();
            this.readHWVersionButton = new System.Windows.Forms.Button();
            this.hwVersionDisplayLabel = new System.Windows.Forms.Label();
            this.setHWVersionButton = new System.Windows.Forms.Button();
            this.hwVerMajTextBox = new System.Windows.Forms.TextBox();
            this.hwVerMajLabel = new System.Windows.Forms.Label();
            this.readLungSerialNumberButton = new System.Windows.Forms.Button();
            this.readLungModelButton = new System.Windows.Forms.Button();
            this.lungSerialNumberDisplayLabel = new System.Windows.Forms.Label();
            this.lungModelDisplayLabel = new System.Windows.Forms.Label();
            this.writeLungSerialNumberButton = new System.Windows.Forms.Button();
            this.writeLungModelButton = new System.Windows.Forms.Button();
            this.lungSerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.lungModelTextBox = new System.Windows.Forms.TextBox();
            this.lungSerialNumberLabel = new System.Windows.Forms.Label();
            this.lungModelLabel = new System.Windows.Forms.Label();
            this.fio2RawDisplayLabel = new System.Windows.Forms.Label();
            this.rltRawDisplayLabel = new System.Windows.Forms.Label();
            this.lltRawDisplayLabel = new System.Windows.Forms.Label();
            this.setReadLSSCDButton = new System.Windows.Forms.Button();
            this.fio2DisplayLabel = new System.Windows.Forms.Label();
            this.rightLungTemperatureDisplayLabel = new System.Windows.Forms.Label();
            this.leftLungTemperatureDisplayLabel = new System.Windows.Forms.Label();
            this.fio2Label = new System.Windows.Forms.Label();
            this.rightLungTemperatureLabel = new System.Windows.Forms.Label();
            this.leftLungTemperatureLabel = new System.Windows.Forms.Label();
            this.PlotsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PressuresPlot = new ScottPlot.FormsPlot();
            this.VolumeFlowPlot = new ScottPlot.FormsPlot();
            this.displayPlotsButton = new System.Windows.Forms.Button();
            this.FactoryControlsPanel.SuspendLayout();
            this.UserControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlotsSplitContainer)).BeginInit();
            this.PlotsSplitContainer.Panel1.SuspendLayout();
            this.PlotsSplitContainer.Panel2.SuspendLayout();
            this.PlotsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // usbCommTimer
            // 
            this.usbCommTimer.Interval = 10;
            this.usbCommTimer.Tick += new System.EventHandler(this.usbCommTimer_Tick);
            // 
            // FactoryControlsPanel
            // 
            this.FactoryControlsPanel.Controls.Add(this.fio2RawDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.rltRawDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.lltRawDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.setReadLSSCDButton);
            this.FactoryControlsPanel.Controls.Add(this.fio2DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.rightLungTemperatureDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.leftLungTemperatureDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.fio2Label);
            this.FactoryControlsPanel.Controls.Add(this.rightLungTemperatureLabel);
            this.FactoryControlsPanel.Controls.Add(this.leftLungTemperatureLabel);
            this.FactoryControlsPanel.Controls.Add(this.readSWVersionButton);
            this.FactoryControlsPanel.Controls.Add(this.swVersionDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.hwVerMinTextBox);
            this.FactoryControlsPanel.Controls.Add(this.hwVerMinLabel);
            this.FactoryControlsPanel.Controls.Add(this.readHWVersionButton);
            this.FactoryControlsPanel.Controls.Add(this.hwVersionDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.setHWVersionButton);
            this.FactoryControlsPanel.Controls.Add(this.hwVerMajTextBox);
            this.FactoryControlsPanel.Controls.Add(this.hwVerMajLabel);
            this.FactoryControlsPanel.Controls.Add(this.readLungSerialNumberButton);
            this.FactoryControlsPanel.Controls.Add(this.readLungModelButton);
            this.FactoryControlsPanel.Controls.Add(this.lungSerialNumberDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.lungModelDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.writeLungSerialNumberButton);
            this.FactoryControlsPanel.Controls.Add(this.writeLungModelButton);
            this.FactoryControlsPanel.Controls.Add(this.lungSerialNumberTextBox);
            this.FactoryControlsPanel.Controls.Add(this.lungModelTextBox);
            this.FactoryControlsPanel.Controls.Add(this.lungSerialNumberLabel);
            this.FactoryControlsPanel.Controls.Add(this.lungModelLabel);
            this.FactoryControlsPanel.Controls.Add(this.setReadComplianceCalibrationDataButton);
            this.FactoryControlsPanel.Controls.Add(this.ch0ZeroDetectedLabel);
            this.FactoryControlsPanel.Controls.Add(this.maxPackageIntervalUnitsLabel);
            this.FactoryControlsPanel.Controls.Add(this.packageIntervalUnitsLabel);
            this.FactoryControlsPanel.Controls.Add(this.maxPackageIntervalDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.maxPackageIntervalLabel);
            this.FactoryControlsPanel.Controls.Add(this.packagesMissedDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.packagesMissedLabel);
            this.FactoryControlsPanel.Controls.Add(this.packageIntervalDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.packageIntervalLabel);
            this.FactoryControlsPanel.Controls.Add(this.auxinDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.phighDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.prghtDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.pleftDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.pproxDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.setReadHSSCDButton);
            this.FactoryControlsPanel.Controls.Add(this.packageCountDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.sizeDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.packageCountLabel);
            this.FactoryControlsPanel.Controls.Add(this.sizeLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch4DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch3DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch2DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch1DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch0DisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.ch4Label);
            this.FactoryControlsPanel.Controls.Add(this.ch3Label);
            this.FactoryControlsPanel.Controls.Add(this.ch2Label);
            this.FactoryControlsPanel.Controls.Add(this.ch1Label);
            this.FactoryControlsPanel.Controls.Add(this.ch0Label);
            this.FactoryControlsPanel.Controls.Add(this.usbInDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.usbOutDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.usbInLabel);
            this.FactoryControlsPanel.Controls.Add(this.usbOutLabel);
            this.FactoryControlsPanel.Controls.Add(this.connectionStateLabel);
            this.FactoryControlsPanel.Controls.Add(this.resetMCUButton);
            this.FactoryControlsPanel.Controls.Add(this.enterBootloaderButton);
            this.FactoryControlsPanel.Controls.Add(this.potProgressBar);
            this.FactoryControlsPanel.Controls.Add(this.auxinBarDisplayLabel);
            this.FactoryControlsPanel.Controls.Add(this.auxinLabel);
            this.FactoryControlsPanel.Controls.Add(this.testHighSpeedDataRateButton);
            this.FactoryControlsPanel.Controls.Add(this.toggleBlinkStatusButton);
            this.FactoryControlsPanel.Controls.Add(this.toggleLEDsButton);
            this.FactoryControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FactoryControlsPanel.Location = new System.Drawing.Point(0, 429);
            this.FactoryControlsPanel.Name = "FactoryControlsPanel";
            this.FactoryControlsPanel.Size = new System.Drawing.Size(1008, 300);
            this.FactoryControlsPanel.TabIndex = 78;
            this.FactoryControlsPanel.Click += new System.EventHandler(this.toggleBlinkStatusButton_Click);
            // 
            // toggleLEDsButton
            // 
            this.toggleLEDsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleLEDsButton.Location = new System.Drawing.Point(12, 274);
            this.toggleLEDsButton.Name = "toggleLEDsButton";
            this.toggleLEDsButton.Size = new System.Drawing.Size(105, 23);
            this.toggleLEDsButton.TabIndex = 2;
            this.toggleLEDsButton.Text = "Toggle LEDs";
            this.toggleLEDsButton.UseVisualStyleBackColor = true;
            this.toggleLEDsButton.Click += new System.EventHandler(this.toggleLEDsButton_Click);
            // 
            // toggleBlinkStatusButton
            // 
            this.toggleBlinkStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleBlinkStatusButton.Location = new System.Drawing.Point(123, 274);
            this.toggleBlinkStatusButton.Name = "toggleBlinkStatusButton";
            this.toggleBlinkStatusButton.Size = new System.Drawing.Size(114, 23);
            this.toggleBlinkStatusButton.TabIndex = 48;
            this.toggleBlinkStatusButton.Text = "Toggle Blink Status";
            this.toggleBlinkStatusButton.UseVisualStyleBackColor = true;
            this.toggleBlinkStatusButton.Click += new System.EventHandler(this.toggleBlinkStatusButton_Click);
            // 
            // testHighSpeedDataRateButton
            // 
            this.testHighSpeedDataRateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testHighSpeedDataRateButton.Location = new System.Drawing.Point(12, 245);
            this.testHighSpeedDataRateButton.Name = "testHighSpeedDataRateButton";
            this.testHighSpeedDataRateButton.Size = new System.Drawing.Size(225, 23);
            this.testHighSpeedDataRateButton.TabIndex = 71;
            this.testHighSpeedDataRateButton.Text = "Test High Speed Data Rate";
            this.testHighSpeedDataRateButton.UseVisualStyleBackColor = true;
            this.testHighSpeedDataRateButton.Click += new System.EventHandler(this.testHighSpeedDataRateButton_Click);
            // 
            // auxinBarDisplayLabel
            // 
            this.auxinBarDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.auxinBarDisplayLabel.Location = new System.Drawing.Point(295, 279);
            this.auxinBarDisplayLabel.Name = "auxinBarDisplayLabel";
            this.auxinBarDisplayLabel.Size = new System.Drawing.Size(45, 13);
            this.auxinBarDisplayLabel.TabIndex = 73;
            this.auxinBarDisplayLabel.Text = "0";
            this.auxinBarDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // auxinLabel
            // 
            this.auxinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.auxinLabel.AutoSize = true;
            this.auxinLabel.Location = new System.Drawing.Point(243, 279);
            this.auxinLabel.Name = "auxinLabel";
            this.auxinLabel.Size = new System.Drawing.Size(46, 13);
            this.auxinLabel.TabIndex = 72;
            this.auxinLabel.Text = "AUX IN:";
            // 
            // potProgressBar
            // 
            this.potProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.potProgressBar.BackColor = System.Drawing.Color.Black;
            this.potProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.potProgressBar.Location = new System.Drawing.Point(346, 281);
            this.potProgressBar.Maximum = 4095;
            this.potProgressBar.Name = "potProgressBar";
            this.potProgressBar.Size = new System.Drawing.Size(393, 10);
            this.potProgressBar.Step = 1;
            this.potProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.potProgressBar.TabIndex = 74;
            // 
            // enterBootloaderButton
            // 
            this.enterBootloaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBootloaderButton.Location = new System.Drawing.Point(781, 274);
            this.enterBootloaderButton.Name = "enterBootloaderButton";
            this.enterBootloaderButton.Size = new System.Drawing.Size(105, 23);
            this.enterBootloaderButton.TabIndex = 75;
            this.enterBootloaderButton.Text = "Enter Bootloader";
            this.enterBootloaderButton.UseVisualStyleBackColor = true;
            this.enterBootloaderButton.Click += new System.EventHandler(this.enterBootloaderButton_Click);
            // 
            // resetMCUButton
            // 
            this.resetMCUButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMCUButton.Location = new System.Drawing.Point(892, 274);
            this.resetMCUButton.Name = "resetMCUButton";
            this.resetMCUButton.Size = new System.Drawing.Size(105, 23);
            this.resetMCUButton.TabIndex = 76;
            this.resetMCUButton.Text = "Reset MCU";
            this.resetMCUButton.UseVisualStyleBackColor = true;
            this.resetMCUButton.Click += new System.EventHandler(this.resetMCUButton_Click);
            // 
            // usbInDisplayLabel
            // 
            this.usbInDisplayLabel.AutoSize = true;
            this.usbInDisplayLabel.Location = new System.Drawing.Point(70, 60);
            this.usbInDisplayLabel.Name = "usbInDisplayLabel";
            this.usbInDisplayLabel.Size = new System.Drawing.Size(19, 13);
            this.usbInDisplayLabel.TabIndex = 81;
            this.usbInDisplayLabel.Text = "00";
            // 
            // usbOutDisplayLabel
            // 
            this.usbOutDisplayLabel.AutoSize = true;
            this.usbOutDisplayLabel.Location = new System.Drawing.Point(70, 38);
            this.usbOutDisplayLabel.Name = "usbOutDisplayLabel";
            this.usbOutDisplayLabel.Size = new System.Drawing.Size(19, 13);
            this.usbOutDisplayLabel.TabIndex = 80;
            this.usbOutDisplayLabel.Text = "00";
            // 
            // usbInLabel
            // 
            this.usbInLabel.AutoSize = true;
            this.usbInLabel.Location = new System.Drawing.Point(20, 60);
            this.usbInLabel.Name = "usbInLabel";
            this.usbInLabel.Size = new System.Drawing.Size(44, 13);
            this.usbInLabel.TabIndex = 79;
            this.usbInLabel.Text = "USB In:";
            this.usbInLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // usbOutLabel
            // 
            this.usbOutLabel.AutoSize = true;
            this.usbOutLabel.Location = new System.Drawing.Point(12, 38);
            this.usbOutLabel.Name = "usbOutLabel";
            this.usbOutLabel.Size = new System.Drawing.Size(52, 13);
            this.usbOutLabel.TabIndex = 78;
            this.usbOutLabel.Text = "USB Out:";
            this.usbOutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // connectionStateLabel
            // 
            this.connectionStateLabel.BackColor = System.Drawing.Color.Yellow;
            this.connectionStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectionStateLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStateLabel.Name = "connectionStateLabel";
            this.connectionStateLabel.Size = new System.Drawing.Size(225, 23);
            this.connectionStateLabel.TabIndex = 77;
            this.connectionStateLabel.Text = "connection state";
            this.connectionStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectionStateLabel.Click += new System.EventHandler(this.connectionStateLabel_Click);
            // 
            // ch0ZeroDetectedLabel
            // 
            this.ch0ZeroDetectedLabel.AutoSize = true;
            this.ch0ZeroDetectedLabel.ForeColor = System.Drawing.Color.Red;
            this.ch0ZeroDetectedLabel.Location = new System.Drawing.Point(200, 117);
            this.ch0ZeroDetectedLabel.Name = "ch0ZeroDetectedLabel";
            this.ch0ZeroDetectedLabel.Size = new System.Drawing.Size(37, 13);
            this.ch0ZeroDetectedLabel.TabIndex = 110;
            this.ch0ZeroDetectedLabel.Text = "ZERO";
            this.ch0ZeroDetectedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ch0ZeroDetectedLabel.Visible = false;
            // 
            // maxPackageIntervalUnitsLabel
            // 
            this.maxPackageIntervalUnitsLabel.AutoSize = true;
            this.maxPackageIntervalUnitsLabel.Location = new System.Drawing.Point(983, 213);
            this.maxPackageIntervalUnitsLabel.Name = "maxPackageIntervalUnitsLabel";
            this.maxPackageIntervalUnitsLabel.Size = new System.Drawing.Size(20, 13);
            this.maxPackageIntervalUnitsLabel.TabIndex = 109;
            this.maxPackageIntervalUnitsLabel.Text = "ms";
            // 
            // packageIntervalUnitsLabel
            // 
            this.packageIntervalUnitsLabel.AutoSize = true;
            this.packageIntervalUnitsLabel.Location = new System.Drawing.Point(983, 189);
            this.packageIntervalUnitsLabel.Name = "packageIntervalUnitsLabel";
            this.packageIntervalUnitsLabel.Size = new System.Drawing.Size(20, 13);
            this.packageIntervalUnitsLabel.TabIndex = 108;
            this.packageIntervalUnitsLabel.Text = "ms";
            // 
            // maxPackageIntervalDisplayLabel
            // 
            this.maxPackageIntervalDisplayLabel.Location = new System.Drawing.Point(943, 213);
            this.maxPackageIntervalDisplayLabel.Name = "maxPackageIntervalDisplayLabel";
            this.maxPackageIntervalDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.maxPackageIntervalDisplayLabel.TabIndex = 107;
            this.maxPackageIntervalDisplayLabel.Text = "0";
            this.maxPackageIntervalDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxPackageIntervalLabel
            // 
            this.maxPackageIntervalLabel.Location = new System.Drawing.Point(813, 213);
            this.maxPackageIntervalLabel.Name = "maxPackageIntervalLabel";
            this.maxPackageIntervalLabel.Size = new System.Drawing.Size(124, 13);
            this.maxPackageIntervalLabel.TabIndex = 106;
            this.maxPackageIntervalLabel.Text = "Max package interval:";
            this.maxPackageIntervalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packagesMissedDisplayLabel
            // 
            this.packagesMissedDisplayLabel.Location = new System.Drawing.Point(943, 237);
            this.packagesMissedDisplayLabel.Name = "packagesMissedDisplayLabel";
            this.packagesMissedDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.packagesMissedDisplayLabel.TabIndex = 105;
            this.packagesMissedDisplayLabel.Text = "0";
            this.packagesMissedDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packagesMissedLabel
            // 
            this.packagesMissedLabel.Location = new System.Drawing.Point(813, 237);
            this.packagesMissedLabel.Name = "packagesMissedLabel";
            this.packagesMissedLabel.Size = new System.Drawing.Size(124, 13);
            this.packagesMissedLabel.TabIndex = 104;
            this.packagesMissedLabel.Text = "Packages missed:";
            this.packagesMissedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packageIntervalDisplayLabel
            // 
            this.packageIntervalDisplayLabel.Location = new System.Drawing.Point(943, 189);
            this.packageIntervalDisplayLabel.Name = "packageIntervalDisplayLabel";
            this.packageIntervalDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.packageIntervalDisplayLabel.TabIndex = 103;
            this.packageIntervalDisplayLabel.Text = "0";
            this.packageIntervalDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packageIntervalLabel
            // 
            this.packageIntervalLabel.Location = new System.Drawing.Point(813, 189);
            this.packageIntervalLabel.Name = "packageIntervalLabel";
            this.packageIntervalLabel.Size = new System.Drawing.Size(124, 13);
            this.packageIntervalLabel.TabIndex = 102;
            this.packageIntervalLabel.Text = "Package interval:";
            this.packageIntervalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // auxinDisplayLabel
            // 
            this.auxinDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxinDisplayLabel.Location = new System.Drawing.Point(126, 208);
            this.auxinDisplayLabel.Name = "auxinDisplayLabel";
            this.auxinDisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.auxinDisplayLabel.TabIndex = 101;
            this.auxinDisplayLabel.Text = "0.00";
            this.auxinDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phighDisplayLabel
            // 
            this.phighDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phighDisplayLabel.Location = new System.Drawing.Point(126, 184);
            this.phighDisplayLabel.Name = "phighDisplayLabel";
            this.phighDisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.phighDisplayLabel.TabIndex = 100;
            this.phighDisplayLabel.Text = "0.00";
            this.phighDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prghtDisplayLabel
            // 
            this.prghtDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prghtDisplayLabel.Location = new System.Drawing.Point(126, 160);
            this.prghtDisplayLabel.Name = "prghtDisplayLabel";
            this.prghtDisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.prghtDisplayLabel.TabIndex = 99;
            this.prghtDisplayLabel.Text = "0.00";
            this.prghtDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pleftDisplayLabel
            // 
            this.pleftDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleftDisplayLabel.Location = new System.Drawing.Point(126, 136);
            this.pleftDisplayLabel.Name = "pleftDisplayLabel";
            this.pleftDisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.pleftDisplayLabel.TabIndex = 98;
            this.pleftDisplayLabel.Text = "0.00";
            this.pleftDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pproxDisplayLabel
            // 
            this.pproxDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pproxDisplayLabel.Location = new System.Drawing.Point(126, 112);
            this.pproxDisplayLabel.Name = "pproxDisplayLabel";
            this.pproxDisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.pproxDisplayLabel.TabIndex = 97;
            this.pproxDisplayLabel.Text = "0.00";
            this.pproxDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // setReadHSSCDButton
            // 
            this.setReadHSSCDButton.Location = new System.Drawing.Point(12, 86);
            this.setReadHSSCDButton.Name = "setReadHSSCDButton";
            this.setReadHSSCDButton.Size = new System.Drawing.Size(225, 23);
            this.setReadHSSCDButton.TabIndex = 96;
            this.setReadHSSCDButton.Text = "Set / Read High Speed Calibration Data";
            this.setReadHSSCDButton.UseVisualStyleBackColor = true;
            this.setReadHSSCDButton.Click += new System.EventHandler(this.setReadHSSCDButton_Click);
            // 
            // packageCountDisplayLabel
            // 
            this.packageCountDisplayLabel.Location = new System.Drawing.Point(943, 165);
            this.packageCountDisplayLabel.Name = "packageCountDisplayLabel";
            this.packageCountDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.packageCountDisplayLabel.TabIndex = 95;
            this.packageCountDisplayLabel.Text = "0";
            this.packageCountDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sizeDisplayLabel
            // 
            this.sizeDisplayLabel.Location = new System.Drawing.Point(943, 141);
            this.sizeDisplayLabel.Name = "sizeDisplayLabel";
            this.sizeDisplayLabel.Size = new System.Drawing.Size(34, 13);
            this.sizeDisplayLabel.TabIndex = 94;
            this.sizeDisplayLabel.Text = "0";
            this.sizeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packageCountLabel
            // 
            this.packageCountLabel.Location = new System.Drawing.Point(813, 165);
            this.packageCountLabel.Name = "packageCountLabel";
            this.packageCountLabel.Size = new System.Drawing.Size(124, 13);
            this.packageCountLabel.TabIndex = 93;
            this.packageCountLabel.Text = "Package count:";
            this.packageCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Location = new System.Drawing.Point(813, 141);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(122, 23);
            this.sizeLabel.TabIndex = 92;
            this.sizeLabel.Text = "Size (SampleCount):";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch4DisplayLabel
            // 
            this.ch4DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch4DisplayLabel.Location = new System.Drawing.Point(65, 208);
            this.ch4DisplayLabel.Name = "ch4DisplayLabel";
            this.ch4DisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.ch4DisplayLabel.TabIndex = 91;
            this.ch4DisplayLabel.Text = "CH4";
            this.ch4DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch3DisplayLabel
            // 
            this.ch3DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch3DisplayLabel.Location = new System.Drawing.Point(65, 184);
            this.ch3DisplayLabel.Name = "ch3DisplayLabel";
            this.ch3DisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.ch3DisplayLabel.TabIndex = 90;
            this.ch3DisplayLabel.Text = "CH3";
            this.ch3DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch2DisplayLabel
            // 
            this.ch2DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2DisplayLabel.Location = new System.Drawing.Point(65, 160);
            this.ch2DisplayLabel.Name = "ch2DisplayLabel";
            this.ch2DisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.ch2DisplayLabel.TabIndex = 89;
            this.ch2DisplayLabel.Text = "CH2";
            this.ch2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch1DisplayLabel
            // 
            this.ch1DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch1DisplayLabel.Location = new System.Drawing.Point(65, 136);
            this.ch1DisplayLabel.Name = "ch1DisplayLabel";
            this.ch1DisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.ch1DisplayLabel.TabIndex = 88;
            this.ch1DisplayLabel.Text = "CH1";
            this.ch1DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch0DisplayLabel
            // 
            this.ch0DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch0DisplayLabel.Location = new System.Drawing.Point(65, 112);
            this.ch0DisplayLabel.Name = "ch0DisplayLabel";
            this.ch0DisplayLabel.Size = new System.Drawing.Size(55, 26);
            this.ch0DisplayLabel.TabIndex = 87;
            this.ch0DisplayLabel.Text = "CH0";
            this.ch0DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ch4Label
            // 
            this.ch4Label.AutoSize = true;
            this.ch4Label.Location = new System.Drawing.Point(9, 213);
            this.ch4Label.Name = "ch4Label";
            this.ch4Label.Size = new System.Drawing.Size(43, 13);
            this.ch4Label.TabIndex = 86;
            this.ch4Label.Text = "AUXIN:";
            // 
            // ch3Label
            // 
            this.ch3Label.AutoSize = true;
            this.ch3Label.Location = new System.Drawing.Point(9, 189);
            this.ch3Label.Name = "ch3Label";
            this.ch3Label.Size = new System.Drawing.Size(44, 13);
            this.ch3Label.TabIndex = 85;
            this.ch3Label.Text = "PHIGH:";
            // 
            // ch2Label
            // 
            this.ch2Label.AutoSize = true;
            this.ch2Label.Location = new System.Drawing.Point(9, 165);
            this.ch2Label.Name = "ch2Label";
            this.ch2Label.Size = new System.Drawing.Size(48, 13);
            this.ch2Label.TabIndex = 84;
            this.ch2Label.Text = "PRGHT:";
            // 
            // ch1Label
            // 
            this.ch1Label.AutoSize = true;
            this.ch1Label.Location = new System.Drawing.Point(9, 141);
            this.ch1Label.Name = "ch1Label";
            this.ch1Label.Size = new System.Drawing.Size(43, 13);
            this.ch1Label.TabIndex = 83;
            this.ch1Label.Text = "PLEFT:";
            // 
            // ch0Label
            // 
            this.ch0Label.AutoSize = true;
            this.ch0Label.Location = new System.Drawing.Point(9, 117);
            this.ch0Label.Name = "ch0Label";
            this.ch0Label.Size = new System.Drawing.Size(47, 13);
            this.ch0Label.TabIndex = 82;
            this.ch0Label.Text = "PPROX:";
            // 
            // UserControlPanel
            // 
            this.UserControlPanel.Controls.Add(this.displayPlotsButton);
            this.UserControlPanel.Controls.Add(this.cumulativeSavedDataTimeUnitsLabel);
            this.UserControlPanel.Controls.Add(this.cumulativeSavedDataTimeDisplayLabel);
            this.UserControlPanel.Controls.Add(this.cumulativeSavedDataTimeLabel);
            this.UserControlPanel.Controls.Add(this.StartStopDataAcquisitionButton);
            this.UserControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserControlPanel.Location = new System.Drawing.Point(0, 350);
            this.UserControlPanel.Name = "UserControlPanel";
            this.UserControlPanel.Size = new System.Drawing.Size(1008, 79);
            this.UserControlPanel.TabIndex = 79;
            // 
            // cumulativeSavedDataTimeUnitsLabel
            // 
            this.cumulativeSavedDataTimeUnitsLabel.AutoSize = true;
            this.cumulativeSavedDataTimeUnitsLabel.Location = new System.Drawing.Point(225, 95);
            this.cumulativeSavedDataTimeUnitsLabel.Name = "cumulativeSavedDataTimeUnitsLabel";
            this.cumulativeSavedDataTimeUnitsLabel.Size = new System.Drawing.Size(12, 13);
            this.cumulativeSavedDataTimeUnitsLabel.TabIndex = 82;
            this.cumulativeSavedDataTimeUnitsLabel.Text = "s";
            // 
            // cumulativeSavedDataTimeDisplayLabel
            // 
            this.cumulativeSavedDataTimeDisplayLabel.Location = new System.Drawing.Point(165, 58);
            this.cumulativeSavedDataTimeDisplayLabel.Name = "cumulativeSavedDataTimeDisplayLabel";
            this.cumulativeSavedDataTimeDisplayLabel.Size = new System.Drawing.Size(54, 13);
            this.cumulativeSavedDataTimeDisplayLabel.TabIndex = 81;
            this.cumulativeSavedDataTimeDisplayLabel.Text = "0.000";
            this.cumulativeSavedDataTimeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cumulativeSavedDataTimeLabel
            // 
            this.cumulativeSavedDataTimeLabel.Location = new System.Drawing.Point(9, 58);
            this.cumulativeSavedDataTimeLabel.Name = "cumulativeSavedDataTimeLabel";
            this.cumulativeSavedDataTimeLabel.Size = new System.Drawing.Size(146, 13);
            this.cumulativeSavedDataTimeLabel.TabIndex = 80;
            this.cumulativeSavedDataTimeLabel.Text = "Cumulative saved data time:";
            this.cumulativeSavedDataTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StartStopDataAcquisitionButton
            // 
            this.StartStopDataAcquisitionButton.Location = new System.Drawing.Point(12, 3);
            this.StartStopDataAcquisitionButton.Name = "StartStopDataAcquisitionButton";
            this.StartStopDataAcquisitionButton.Size = new System.Drawing.Size(146, 23);
            this.StartStopDataAcquisitionButton.TabIndex = 78;
            this.StartStopDataAcquisitionButton.Text = "Start Data Acquisition";
            this.StartStopDataAcquisitionButton.UseVisualStyleBackColor = true;
            this.StartStopDataAcquisitionButton.Click += new System.EventHandler(this.startDataAcquisitionButton_Click);
            // 
            // setReadComplianceCalibrationDataButton
            // 
            this.setReadComplianceCalibrationDataButton.Location = new System.Drawing.Point(243, 86);
            this.setReadComplianceCalibrationDataButton.Name = "setReadComplianceCalibrationDataButton";
            this.setReadComplianceCalibrationDataButton.Size = new System.Drawing.Size(229, 23);
            this.setReadComplianceCalibrationDataButton.TabIndex = 112;
            this.setReadComplianceCalibrationDataButton.Text = "Set / Read Compliance Calibration Data";
            this.setReadComplianceCalibrationDataButton.UseVisualStyleBackColor = true;
            this.setReadComplianceCalibrationDataButton.Click += new System.EventHandler(this.setReadComplianceCalibrationDataButton_Click);
            // 
            // readSWVersionButton
            // 
            this.readSWVersionButton.Location = new System.Drawing.Point(545, 223);
            this.readSWVersionButton.Name = "readSWVersionButton";
            this.readSWVersionButton.Size = new System.Drawing.Size(114, 23);
            this.readSWVersionButton.TabIndex = 131;
            this.readSWVersionButton.Text = "Read FW Version";
            this.readSWVersionButton.UseVisualStyleBackColor = true;
            this.readSWVersionButton.Click += new System.EventHandler(this.readSWVersionButton_Click);
            // 
            // swVersionDisplayLabel
            // 
            this.swVersionDisplayLabel.AutoSize = true;
            this.swVersionDisplayLabel.Location = new System.Drawing.Point(665, 228);
            this.swVersionDisplayLabel.Name = "swVersionDisplayLabel";
            this.swVersionDisplayLabel.Size = new System.Drawing.Size(136, 13);
            this.swVersionDisplayLabel.TabIndex = 130;
            this.swVersionDisplayLabel.Text = "Invalid FW Version Number";
            // 
            // hwVerMinTextBox
            // 
            this.hwVerMinTextBox.Location = new System.Drawing.Point(387, 196);
            this.hwVerMinTextBox.Name = "hwVerMinTextBox";
            this.hwVerMinTextBox.Size = new System.Drawing.Size(32, 20);
            this.hwVerMinTextBox.TabIndex = 129;
            this.hwVerMinTextBox.Text = "3";
            this.hwVerMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hwVerMinLabel
            // 
            this.hwVerMinLabel.Location = new System.Drawing.Point(306, 199);
            this.hwVerMinLabel.Name = "hwVerMinLabel";
            this.hwVerMinLabel.Size = new System.Drawing.Size(75, 13);
            this.hwVerMinLabel.TabIndex = 128;
            this.hwVerMinLabel.Text = "HW Ver Min:";
            this.hwVerMinLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // readHWVersionButton
            // 
            this.readHWVersionButton.Location = new System.Drawing.Point(545, 194);
            this.readHWVersionButton.Name = "readHWVersionButton";
            this.readHWVersionButton.Size = new System.Drawing.Size(114, 23);
            this.readHWVersionButton.TabIndex = 127;
            this.readHWVersionButton.Text = "Read HW Version";
            this.readHWVersionButton.UseVisualStyleBackColor = true;
            this.readHWVersionButton.Click += new System.EventHandler(this.readHWVersionButton_Click);
            // 
            // hwVersionDisplayLabel
            // 
            this.hwVersionDisplayLabel.AutoSize = true;
            this.hwVersionDisplayLabel.Location = new System.Drawing.Point(665, 199);
            this.hwVersionDisplayLabel.Name = "hwVersionDisplayLabel";
            this.hwVersionDisplayLabel.Size = new System.Drawing.Size(138, 13);
            this.hwVersionDisplayLabel.TabIndex = 126;
            this.hwVersionDisplayLabel.Text = "Invalid HW Version Number";
            // 
            // setHWVersionButton
            // 
            this.setHWVersionButton.Location = new System.Drawing.Point(425, 194);
            this.setHWVersionButton.Name = "setHWVersionButton";
            this.setHWVersionButton.Size = new System.Drawing.Size(114, 23);
            this.setHWVersionButton.TabIndex = 125;
            this.setHWVersionButton.Text = "Set HW Version";
            this.setHWVersionButton.UseVisualStyleBackColor = true;
            this.setHWVersionButton.Click += new System.EventHandler(this.setHWVersionButton_Click);
            // 
            // hwVerMajTextBox
            // 
            this.hwVerMajTextBox.Location = new System.Drawing.Point(268, 196);
            this.hwVerMajTextBox.Name = "hwVerMajTextBox";
            this.hwVerMajTextBox.Size = new System.Drawing.Size(32, 20);
            this.hwVerMajTextBox.TabIndex = 124;
            this.hwVerMajTextBox.Text = "3";
            this.hwVerMajTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hwVerMajLabel
            // 
            this.hwVerMajLabel.Location = new System.Drawing.Point(187, 199);
            this.hwVerMajLabel.Name = "hwVerMajLabel";
            this.hwVerMajLabel.Size = new System.Drawing.Size(75, 13);
            this.hwVerMajLabel.TabIndex = 123;
            this.hwVerMajLabel.Text = "HW Ver Maj:";
            this.hwVerMajLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // readLungSerialNumberButton
            // 
            this.readLungSerialNumberButton.Location = new System.Drawing.Point(513, 165);
            this.readLungSerialNumberButton.Name = "readLungSerialNumberButton";
            this.readLungSerialNumberButton.Size = new System.Drawing.Size(146, 23);
            this.readLungSerialNumberButton.TabIndex = 122;
            this.readLungSerialNumberButton.Text = "Read Lung Serial Number";
            this.readLungSerialNumberButton.UseVisualStyleBackColor = true;
            this.readLungSerialNumberButton.Click += new System.EventHandler(this.readLungSerialNumberButton_Click);
            // 
            // readLungModelButton
            // 
            this.readLungModelButton.Location = new System.Drawing.Point(513, 136);
            this.readLungModelButton.Name = "readLungModelButton";
            this.readLungModelButton.Size = new System.Drawing.Size(146, 23);
            this.readLungModelButton.TabIndex = 121;
            this.readLungModelButton.Text = "Read Lung Model";
            this.readLungModelButton.UseVisualStyleBackColor = true;
            this.readLungModelButton.Click += new System.EventHandler(this.readLungModelButton_Click);
            // 
            // lungSerialNumberDisplayLabel
            // 
            this.lungSerialNumberDisplayLabel.AutoSize = true;
            this.lungSerialNumberDisplayLabel.Location = new System.Drawing.Point(665, 170);
            this.lungSerialNumberDisplayLabel.Name = "lungSerialNumberDisplayLabel";
            this.lungSerialNumberDisplayLabel.Size = new System.Drawing.Size(134, 13);
            this.lungSerialNumberDisplayLabel.TabIndex = 120;
            this.lungSerialNumberDisplayLabel.Text = "Invalid Lung Serial Number";
            // 
            // lungModelDisplayLabel
            // 
            this.lungModelDisplayLabel.AutoSize = true;
            this.lungModelDisplayLabel.Location = new System.Drawing.Point(665, 141);
            this.lungModelDisplayLabel.Name = "lungModelDisplayLabel";
            this.lungModelDisplayLabel.Size = new System.Drawing.Size(97, 13);
            this.lungModelDisplayLabel.TabIndex = 119;
            this.lungModelDisplayLabel.Text = "Invalid Lung Model";
            // 
            // writeLungSerialNumberButton
            // 
            this.writeLungSerialNumberButton.Location = new System.Drawing.Point(361, 165);
            this.writeLungSerialNumberButton.Name = "writeLungSerialNumberButton";
            this.writeLungSerialNumberButton.Size = new System.Drawing.Size(146, 23);
            this.writeLungSerialNumberButton.TabIndex = 118;
            this.writeLungSerialNumberButton.Text = "Set Lung Serial Number";
            this.writeLungSerialNumberButton.UseVisualStyleBackColor = true;
            this.writeLungSerialNumberButton.Click += new System.EventHandler(this.writeLungSerialNumberButton_Click);
            // 
            // writeLungModelButton
            // 
            this.writeLungModelButton.Location = new System.Drawing.Point(361, 136);
            this.writeLungModelButton.Name = "writeLungModelButton";
            this.writeLungModelButton.Size = new System.Drawing.Size(146, 23);
            this.writeLungModelButton.TabIndex = 117;
            this.writeLungModelButton.Text = "Set Lung Model";
            this.writeLungModelButton.UseVisualStyleBackColor = true;
            this.writeLungModelButton.Click += new System.EventHandler(this.writeLungModelButton_Click);
            // 
            // lungSerialNumberTextBox
            // 
            this.lungSerialNumberTextBox.Location = new System.Drawing.Point(298, 167);
            this.lungSerialNumberTextBox.Name = "lungSerialNumberTextBox";
            this.lungSerialNumberTextBox.Size = new System.Drawing.Size(57, 20);
            this.lungSerialNumberTextBox.TabIndex = 116;
            // 
            // lungModelTextBox
            // 
            this.lungModelTextBox.Location = new System.Drawing.Point(298, 138);
            this.lungModelTextBox.Name = "lungModelTextBox";
            this.lungModelTextBox.Size = new System.Drawing.Size(57, 20);
            this.lungModelTextBox.TabIndex = 115;
            // 
            // lungSerialNumberLabel
            // 
            this.lungSerialNumberLabel.Location = new System.Drawing.Point(187, 170);
            this.lungSerialNumberLabel.Name = "lungSerialNumberLabel";
            this.lungSerialNumberLabel.Size = new System.Drawing.Size(105, 13);
            this.lungSerialNumberLabel.TabIndex = 114;
            this.lungSerialNumberLabel.Text = "Lung Serial Number:";
            this.lungSerialNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lungModelLabel
            // 
            this.lungModelLabel.Location = new System.Drawing.Point(187, 141);
            this.lungModelLabel.Name = "lungModelLabel";
            this.lungModelLabel.Size = new System.Drawing.Size(105, 13);
            this.lungModelLabel.TabIndex = 113;
            this.lungModelLabel.Text = "Lung Model:";
            this.lungModelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fio2RawDisplayLabel
            // 
            this.fio2RawDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio2RawDisplayLabel.Location = new System.Drawing.Point(660, 57);
            this.fio2RawDisplayLabel.Name = "fio2RawDisplayLabel";
            this.fio2RawDisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.fio2RawDisplayLabel.TabIndex = 141;
            this.fio2RawDisplayLabel.Text = "0";
            this.fio2RawDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rltRawDisplayLabel
            // 
            this.rltRawDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rltRawDisplayLabel.Location = new System.Drawing.Point(660, 32);
            this.rltRawDisplayLabel.Name = "rltRawDisplayLabel";
            this.rltRawDisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.rltRawDisplayLabel.TabIndex = 140;
            this.rltRawDisplayLabel.Text = "0";
            this.rltRawDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lltRawDisplayLabel
            // 
            this.lltRawDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lltRawDisplayLabel.Location = new System.Drawing.Point(660, 9);
            this.lltRawDisplayLabel.Name = "lltRawDisplayLabel";
            this.lltRawDisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.lltRawDisplayLabel.TabIndex = 139;
            this.lltRawDisplayLabel.Text = "0";
            this.lltRawDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // setReadLSSCDButton
            // 
            this.setReadLSSCDButton.Location = new System.Drawing.Point(533, 86);
            this.setReadLSSCDButton.Name = "setReadLSSCDButton";
            this.setReadLSSCDButton.Size = new System.Drawing.Size(247, 23);
            this.setReadLSSCDButton.TabIndex = 138;
            this.setReadLSSCDButton.Text = "Set / Read Low Speed Calibration Data";
            this.setReadLSSCDButton.UseVisualStyleBackColor = true;
            this.setReadLSSCDButton.Click += new System.EventHandler(this.setReadLSSCDButton_Click);
            // 
            // fio2DisplayLabel
            // 
            this.fio2DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio2DisplayLabel.Location = new System.Drawing.Point(723, 57);
            this.fio2DisplayLabel.Name = "fio2DisplayLabel";
            this.fio2DisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.fio2DisplayLabel.TabIndex = 137;
            this.fio2DisplayLabel.Text = "0.0";
            this.fio2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightLungTemperatureDisplayLabel
            // 
            this.rightLungTemperatureDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLungTemperatureDisplayLabel.Location = new System.Drawing.Point(723, 32);
            this.rightLungTemperatureDisplayLabel.Name = "rightLungTemperatureDisplayLabel";
            this.rightLungTemperatureDisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.rightLungTemperatureDisplayLabel.TabIndex = 136;
            this.rightLungTemperatureDisplayLabel.Text = "0.000";
            this.rightLungTemperatureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leftLungTemperatureDisplayLabel
            // 
            this.leftLungTemperatureDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLungTemperatureDisplayLabel.Location = new System.Drawing.Point(723, 9);
            this.leftLungTemperatureDisplayLabel.Name = "leftLungTemperatureDisplayLabel";
            this.leftLungTemperatureDisplayLabel.Size = new System.Drawing.Size(57, 18);
            this.leftLungTemperatureDisplayLabel.TabIndex = 135;
            this.leftLungTemperatureDisplayLabel.Text = "0.000";
            this.leftLungTemperatureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fio2Label
            // 
            this.fio2Label.Location = new System.Drawing.Point(530, 62);
            this.fio2Label.Name = "fio2Label";
            this.fio2Label.Size = new System.Drawing.Size(124, 23);
            this.fio2Label.TabIndex = 134;
            this.fio2Label.Text = "FiO2";
            this.fio2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightLungTemperatureLabel
            // 
            this.rightLungTemperatureLabel.Location = new System.Drawing.Point(530, 37);
            this.rightLungTemperatureLabel.Name = "rightLungTemperatureLabel";
            this.rightLungTemperatureLabel.Size = new System.Drawing.Size(124, 23);
            this.rightLungTemperatureLabel.TabIndex = 133;
            this.rightLungTemperatureLabel.Text = "Right Lung Temperature";
            this.rightLungTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leftLungTemperatureLabel
            // 
            this.leftLungTemperatureLabel.Location = new System.Drawing.Point(530, 14);
            this.leftLungTemperatureLabel.Name = "leftLungTemperatureLabel";
            this.leftLungTemperatureLabel.Size = new System.Drawing.Size(124, 23);
            this.leftLungTemperatureLabel.TabIndex = 132;
            this.leftLungTemperatureLabel.Text = "Left Lung Temperature";
            this.leftLungTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlotsSplitContainer
            // 
            this.PlotsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.PlotsSplitContainer.Name = "PlotsSplitContainer";
            this.PlotsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PlotsSplitContainer.Panel1
            // 
            this.PlotsSplitContainer.Panel1.Controls.Add(this.PressuresPlot);
            // 
            // PlotsSplitContainer.Panel2
            // 
            this.PlotsSplitContainer.Panel2.Controls.Add(this.VolumeFlowPlot);
            this.PlotsSplitContainer.Size = new System.Drawing.Size(1008, 350);
            this.PlotsSplitContainer.SplitterDistance = 176;
            this.PlotsSplitContainer.TabIndex = 80;
            // 
            // PressuresPlot
            // 
            this.PressuresPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressuresPlot.Location = new System.Drawing.Point(0, 0);
            this.PressuresPlot.Name = "PressuresPlot";
            this.PressuresPlot.Size = new System.Drawing.Size(1008, 176);
            this.PressuresPlot.TabIndex = 0;
            // 
            // VolumeFlowPlot
            // 
            this.VolumeFlowPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeFlowPlot.Location = new System.Drawing.Point(0, 0);
            this.VolumeFlowPlot.Name = "VolumeFlowPlot";
            this.VolumeFlowPlot.Size = new System.Drawing.Size(1008, 170);
            this.VolumeFlowPlot.TabIndex = 0;
            // 
            // displayPlotsButton
            // 
            this.displayPlotsButton.Location = new System.Drawing.Point(857, 6);
            this.displayPlotsButton.Name = "displayPlotsButton";
            this.displayPlotsButton.Size = new System.Drawing.Size(146, 23);
            this.displayPlotsButton.TabIndex = 112;
            this.displayPlotsButton.Text = "Display Plots";
            this.displayPlotsButton.UseVisualStyleBackColor = true;
            this.displayPlotsButton.Click += new System.EventHandler(this.displayPlotsButton_Click);
            // 
            // PV3TestUtility3Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PlotsSplitContainer);
            this.Controls.Add(this.UserControlPanel);
            this.Controls.Add(this.FactoryControlsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PV3TestUtility3Main";
            this.Text = "PneuView 3 Test Utility v3.0";
            this.Load += new System.EventHandler(this.PV3TestUtility3Main_Load);
            this.FactoryControlsPanel.ResumeLayout(false);
            this.FactoryControlsPanel.PerformLayout();
            this.UserControlPanel.ResumeLayout(false);
            this.UserControlPanel.PerformLayout();
            this.PlotsSplitContainer.Panel1.ResumeLayout(false);
            this.PlotsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlotsSplitContainer)).EndInit();
            this.PlotsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer usbCommTimer;
        private System.Windows.Forms.Panel FactoryControlsPanel;
        private System.Windows.Forms.Button toggleLEDsButton;
        private System.Windows.Forms.Button toggleBlinkStatusButton;
        private System.Windows.Forms.Button testHighSpeedDataRateButton;
        private System.Windows.Forms.Label auxinBarDisplayLabel;
        private System.Windows.Forms.Label auxinLabel;
        private System.Windows.Forms.Button resetMCUButton;
        private System.Windows.Forms.Button enterBootloaderButton;
        private System.Windows.Forms.ProgressBar potProgressBar;
        private System.Windows.Forms.Label ch0ZeroDetectedLabel;
        private System.Windows.Forms.Label maxPackageIntervalUnitsLabel;
        private System.Windows.Forms.Label packageIntervalUnitsLabel;
        private System.Windows.Forms.Label maxPackageIntervalDisplayLabel;
        private System.Windows.Forms.Label maxPackageIntervalLabel;
        private System.Windows.Forms.Label packagesMissedDisplayLabel;
        private System.Windows.Forms.Label packagesMissedLabel;
        private System.Windows.Forms.Label packageIntervalDisplayLabel;
        private System.Windows.Forms.Label packageIntervalLabel;
        private System.Windows.Forms.Label auxinDisplayLabel;
        private System.Windows.Forms.Label phighDisplayLabel;
        private System.Windows.Forms.Label prghtDisplayLabel;
        private System.Windows.Forms.Label pleftDisplayLabel;
        private System.Windows.Forms.Label pproxDisplayLabel;
        private System.Windows.Forms.Button setReadHSSCDButton;
        private System.Windows.Forms.Label packageCountDisplayLabel;
        private System.Windows.Forms.Label sizeDisplayLabel;
        private System.Windows.Forms.Label packageCountLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label ch4DisplayLabel;
        private System.Windows.Forms.Label ch3DisplayLabel;
        private System.Windows.Forms.Label ch2DisplayLabel;
        private System.Windows.Forms.Label ch1DisplayLabel;
        private System.Windows.Forms.Label ch0DisplayLabel;
        private System.Windows.Forms.Label ch4Label;
        private System.Windows.Forms.Label ch3Label;
        private System.Windows.Forms.Label ch2Label;
        private System.Windows.Forms.Label ch1Label;
        private System.Windows.Forms.Label ch0Label;
        private System.Windows.Forms.Label usbInDisplayLabel;
        private System.Windows.Forms.Label usbOutDisplayLabel;
        private System.Windows.Forms.Label usbInLabel;
        private System.Windows.Forms.Label usbOutLabel;
        private System.Windows.Forms.Label connectionStateLabel;
        private System.Windows.Forms.Button readSWVersionButton;
        private System.Windows.Forms.Label swVersionDisplayLabel;
        private System.Windows.Forms.TextBox hwVerMinTextBox;
        private System.Windows.Forms.Label hwVerMinLabel;
        private System.Windows.Forms.Button readHWVersionButton;
        private System.Windows.Forms.Label hwVersionDisplayLabel;
        private System.Windows.Forms.Button setHWVersionButton;
        private System.Windows.Forms.TextBox hwVerMajTextBox;
        private System.Windows.Forms.Label hwVerMajLabel;
        private System.Windows.Forms.Button readLungSerialNumberButton;
        private System.Windows.Forms.Button readLungModelButton;
        private System.Windows.Forms.Label lungSerialNumberDisplayLabel;
        private System.Windows.Forms.Label lungModelDisplayLabel;
        private System.Windows.Forms.Button writeLungSerialNumberButton;
        private System.Windows.Forms.Button writeLungModelButton;
        private System.Windows.Forms.TextBox lungSerialNumberTextBox;
        private System.Windows.Forms.TextBox lungModelTextBox;
        private System.Windows.Forms.Label lungSerialNumberLabel;
        private System.Windows.Forms.Label lungModelLabel;
        private System.Windows.Forms.Button setReadComplianceCalibrationDataButton;
        private System.Windows.Forms.Panel UserControlPanel;
        private System.Windows.Forms.Label cumulativeSavedDataTimeUnitsLabel;
        private System.Windows.Forms.Label cumulativeSavedDataTimeDisplayLabel;
        private System.Windows.Forms.Label cumulativeSavedDataTimeLabel;
        private System.Windows.Forms.Button StartStopDataAcquisitionButton;
        private System.Windows.Forms.Label fio2RawDisplayLabel;
        private System.Windows.Forms.Label rltRawDisplayLabel;
        private System.Windows.Forms.Label lltRawDisplayLabel;
        private System.Windows.Forms.Button setReadLSSCDButton;
        private System.Windows.Forms.Label fio2DisplayLabel;
        private System.Windows.Forms.Label rightLungTemperatureDisplayLabel;
        private System.Windows.Forms.Label leftLungTemperatureDisplayLabel;
        private System.Windows.Forms.Label fio2Label;
        private System.Windows.Forms.Label rightLungTemperatureLabel;
        private System.Windows.Forms.Label leftLungTemperatureLabel;
        private System.Windows.Forms.SplitContainer PlotsSplitContainer;
        private ScottPlot.FormsPlot PressuresPlot;
        private ScottPlot.FormsPlot VolumeFlowPlot;
        private System.Windows.Forms.Button displayPlotsButton;
    }
}

