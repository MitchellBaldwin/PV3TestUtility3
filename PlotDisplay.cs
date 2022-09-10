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
    public partial class PlotDisplay : Form
    {
        private const int sampleCount = 10000;
        private const int sampleRate = 500;

        private double displayUpdateInterval = 0.010;
        public double DisplayUpdateInterval { get => displayUpdateInterval; set => displayUpdateInterval = value; }

        private Stopwatch stopwatch = new Stopwatch();

        double[] airwayPressureStream = new double[sampleCount];
        double[] leftLungPressureStream = new double[sampleCount];
        double[] rightLungPressureStream = new double[sampleCount];
        double[] volumeStream = new double[sampleCount];
        double[] leftVolumeStream = new double[sampleCount];
        double[] rightVolumeStream = new double[sampleCount];
        double[] flowStream = new double[sampleCount];
        //double[] leftFlowStream = new double[sampleCount];
        //double[] rightFlowStream = new double[sampleCount];

        double minTime = 0.0;
        double maxTime = 10.0;

        ScottPlot.Plottable.SignalPlot airwayPressureSignal;
        ScottPlot.Plottable.SignalPlot leftLungPressureSignal;
        ScottPlot.Plottable.SignalPlot rightLungPressureSignal;
        ScottPlot.Plottable.SignalPlot volumeSignal;
        ScottPlot.Plottable.SignalPlot leftVolumeSignal;
        ScottPlot.Plottable.SignalPlot rightVolumeSignal;
        ScottPlot.Plottable.SignalPlot flowSignal;
                
        // Default constructor
        public PlotDisplay()
        {
            InitializeComponent();
        }

        private void PlotDisplay_Load(object sender, EventArgs e)
        {
            DisplayUpdateInterval = testTimer.Interval / 1000.0;
            
            pressurePlot.Plot.XAxis.TickLabelFormat("0.000", false);
            pressurePlot.Plot.XAxis.LabelStyle(fontSize: 10);
            pressurePlot.Plot.XLabel("Time (s)");

            pressurePlot.Plot.YAxis.TickLabelFormat("0.00", false);
            pressurePlot.Plot.YAxis.LabelStyle(fontSize: 10);
            pressurePlot.Plot.YLabel("Airway Pressure (cmH2O)");

            pressurePlot.Plot.YAxis2.TickLabelFormat("0.00", false);
            pressurePlot.Plot.YAxis2.Ticks(true);
            pressurePlot.Plot.YAxis2.LabelStyle(fontSize: 10);
            pressurePlot.Plot.YAxis2.Label("Lung Pressure (cmH2O)");
            pressurePlot.Plot.YAxis2.Edge = ScottPlot.Renderable.Edge.Right;
            pressurePlot.Plot.YAxis2.IsVisible = true;

            volumePlot.Plot.XAxis.TickLabelFormat("0.000", false);
            volumePlot.Plot.XAxis.LabelStyle(fontSize: 10);
            volumePlot.Plot.XLabel("Time (s)");

            volumePlot.Plot.YAxis.TickLabelFormat("0", false);
            volumePlot.Plot.YAxis.LabelStyle(fontSize: 10);
            volumePlot.Plot.YLabel("Volume (mL)");

            // DONE: Second Y axis doesn't seem to appear...
            volumePlot.Plot.YAxis2.TickLabelFormat("0.0", false);
            volumePlot.Plot.YAxis2.Ticks(true);
            volumePlot.Plot.YAxis2.LabelStyle(fontSize: 10);
            volumePlot.Plot.YAxis2.Label("Flow (L/min)");
            volumePlot.Plot.YAxis2.Edge = ScottPlot.Renderable.Edge.Right;
            volumePlot.Plot.YAxis2.IsVisible = true;

            SetDefaultAxisLimits();

            GenerateDummyData();

            pressurePlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            volumePlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);

            pressurePlot.Render();
            volumePlot.Render();

        }

        private void GenerateDummyData()
        {
            // TEST: Test plot rendering using procedurally generated data:
            airwayPressureStream = ScottPlot.DataGen.Sin(sampleCount, 10, 10, 5);
            leftLungPressureStream = ScottPlot.DataGen.Sin(sampleCount, 10, 8, 5);
            rightLungPressureStream = ScottPlot.DataGen.Sin(sampleCount, 10, 4, 5);
            volumeStream = ScottPlot.DataGen.Cos(sampleCount, 10, 1000, 100);
            leftVolumeStream = ScottPlot.DataGen.Cos(sampleCount, 10, 400, 50);
            rightVolumeStream = ScottPlot.DataGen.Cos(sampleCount, 10, 600, 50);
            flowStream = ScottPlot.DataGen.Sin(sampleCount, 10, 0, 20);
            //double[] dummyAirwayPressureData = ScottPlot.DataGen.Sin(sampleCount, 10, 10, 5);
            //double[] dummyLeftLungPressureData = ScottPlot.DataGen.Sin(sampleCount, 10, 8, 5);
            //double[] dummyRightLungPressureData = ScottPlot.DataGen.Sin(sampleCount, 10, 4, 5);
            //double[] dummyVolumeData = ScottPlot.DataGen.Cos(sampleCount, 10, 1000, 100);
            //double[] dummyLeftVolumeData = ScottPlot.DataGen.Cos(sampleCount, 10, 400, 50);
            //double[] dummyRightVolumeData = ScottPlot.DataGen.Cos(sampleCount, 10, 600, 50);
            //double[] dummyFlowData = ScottPlot.DataGen.Sin(sampleCount, 10, 0, 20);

            airwayPressureSignal = pressurePlot.Plot.AddSignal(airwayPressureStream, sampleRate, Color.Aqua, "Airway");
            leftLungPressureSignal = pressurePlot.Plot.AddSignal(leftLungPressureStream, sampleRate, Color.Green, "Left");
            leftLungPressureSignal.YAxisIndex = 1;
            rightLungPressureSignal = pressurePlot.Plot.AddSignal(rightLungPressureStream, sampleRate, Color.Blue, "Right");
            rightLungPressureSignal.YAxisIndex = 1;

            volumeSignal = volumePlot.Plot.AddSignal(volumeStream, sampleRate, Color.OrangeRed, "Total");
            leftVolumeSignal = volumePlot.Plot.AddSignal(leftVolumeStream, sampleRate, Color.Orange, "Left");
            leftVolumeSignal.YAxisIndex = 0;
            rightVolumeSignal = volumePlot.Plot.AddSignal(rightVolumeStream, sampleRate, Color.Red, "Right");
            rightVolumeSignal.YAxisIndex = 0;

            flowSignal = volumePlot.Plot.AddSignal(flowStream, sampleRate, Color.Purple, "Flow");
            flowSignal.YAxisIndex = 1;
        }

        private void SetDefaultAxisLimits()
        {
            minTime = 0.0;
            maxTime = 10.0;

            pressurePlot.Plot.SetAxisLimitsX(minTime, maxTime);
            pressurePlot.Plot.SetAxisLimitsY(0.0, 120.0);
            pressurePlot.Plot.SetAxisLimits(yMin: 0.0, yMax: 120.0, yAxisIndex: 1);

            volumePlot.Plot.SetAxisLimitsX(minTime, maxTime);
            volumePlot.Plot.SetAxisLimitsY(0, 2000);
            volumePlot.Plot.SetAxisLimits(yMin: -60.0, yMax: 60.0, yAxisIndex: 1);

        }

        public void UpdateDisplay(double interval = 0.010)
        {
            minTime += interval;
            maxTime += interval;

            pressurePlot.Plot.SetAxisLimitsX(minTime, maxTime);
            volumePlot.Plot.SetAxisLimitsX(minTime, maxTime);

            TimeBaselineDisplayLabel.Text = (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.000");

            pressurePlot.Render(true, true);
            volumePlot.Render(true, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            testTimer.Enabled = !testTimer.Enabled;
            if (testTimer.Enabled)
            {
                startButton.Text = "Pause";
                stopwatch.Start();
            }
            else
            {
                startButton.Text = "Start";
                stopwatch.Stop();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetDefaultAxisLimits();

            stopwatch.Reset();
            TimeBaselineDisplayLabel.Text = (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.000");
            if (testTimer.Enabled)
            {
                testTimer.Stop();
                testTimer.Start();
                stopwatch.Start();
            }

            pressurePlot.Render(true, false);
            volumePlot.Render(true, false);
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            UpdateDisplay(DisplayUpdateInterval);
        }

        private void showAllPressuresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            leftLungPressureSignal.IsVisible = showAllPressuresCheckBox.Checked;
            rightLungPressureSignal.IsVisible = showAllPressuresCheckBox.Checked;

            pressurePlot.Render();
        }

        private void showAllVolumesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            leftVolumeSignal.IsVisible = showAllVolumesCheckBox.Checked;
            rightVolumeSignal.IsVisible = showAllVolumesCheckBox.Checked;

            volumePlot.Render();
        }
    }
}
