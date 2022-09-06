
namespace PV3TestUtility3
{
    partial class PlotDisplay
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
            this.pressurePlot = new ScottPlot.FormsPlot();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.volumePlot = new ScottPlot.FormsPlot();
            this.resetButton = new System.Windows.Forms.Button();
            this.showAllPressuresCheckBox = new System.Windows.Forms.CheckBox();
            this.showAllVolumesCheckBox = new System.Windows.Forms.CheckBox();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pressurePlot
            // 
            this.pressurePlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.pressurePlot.Location = new System.Drawing.Point(0, 0);
            this.pressurePlot.Name = "pressurePlot";
            this.pressurePlot.Size = new System.Drawing.Size(1008, 300);
            this.pressurePlot.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.showAllVolumesCheckBox);
            this.controlPanel.Controls.Add(this.showAllPressuresCheckBox);
            this.controlPanel.Controls.Add(this.resetButton);
            this.controlPanel.Controls.Add(this.startButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 694);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1008, 35);
            this.controlPanel.TabIndex = 1;
            // 
            // testTimer
            // 
            this.testTimer.Interval = 10;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(93, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // volumePlot
            // 
            this.volumePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumePlot.Location = new System.Drawing.Point(0, 300);
            this.volumePlot.Name = "volumePlot";
            this.volumePlot.Size = new System.Drawing.Size(1008, 394);
            this.volumePlot.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 6);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // showAllPressuresCheckBox
            // 
            this.showAllPressuresCheckBox.AutoSize = true;
            this.showAllPressuresCheckBox.Checked = true;
            this.showAllPressuresCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllPressuresCheckBox.Location = new System.Drawing.Point(255, 11);
            this.showAllPressuresCheckBox.Name = "showAllPressuresCheckBox";
            this.showAllPressuresCheckBox.Size = new System.Drawing.Size(171, 17);
            this.showAllPressuresCheckBox.TabIndex = 2;
            this.showAllPressuresCheckBox.Text = "Show individual lung pressures";
            this.showAllPressuresCheckBox.UseVisualStyleBackColor = true;
            this.showAllPressuresCheckBox.CheckedChanged += new System.EventHandler(this.showAllPressuresCheckBox_CheckedChanged);
            // 
            // showAllVolumesCheckBox
            // 
            this.showAllVolumesCheckBox.AutoSize = true;
            this.showAllVolumesCheckBox.Checked = true;
            this.showAllVolumesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllVolumesCheckBox.Location = new System.Drawing.Point(432, 11);
            this.showAllVolumesCheckBox.Name = "showAllVolumesCheckBox";
            this.showAllVolumesCheckBox.Size = new System.Drawing.Size(165, 17);
            this.showAllVolumesCheckBox.TabIndex = 3;
            this.showAllVolumesCheckBox.Text = "Show individual lung volumes";
            this.showAllVolumesCheckBox.UseVisualStyleBackColor = true;
            this.showAllVolumesCheckBox.CheckedChanged += new System.EventHandler(this.showAllVolumesCheckBox_CheckedChanged);
            // 
            // PlotDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.volumePlot);
            this.Controls.Add(this.pressurePlot);
            this.Controls.Add(this.controlPanel);
            this.Name = "PlotDisplay";
            this.Text = "Data Streams Display";
            this.Load += new System.EventHandler(this.PlotDisplay_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot pressurePlot;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Button startButton;
        private ScottPlot.FormsPlot volumePlot;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox showAllPressuresCheckBox;
        private System.Windows.Forms.CheckBox showAllVolumesCheckBox;
    }
}