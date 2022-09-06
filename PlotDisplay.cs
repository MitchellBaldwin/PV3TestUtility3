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
    public partial class PlotDisplay : Form
    {
        double minTime = 0.0;
        double maxTime = 10.0;

        ScottPlot.Plottable.SignalPlot airwayPressureSignal;
        ScottPlot.Plottable.SignalPlot leftLungPressureSignal;
        ScottPlot.Plottable.SignalPlot rightLungPressureSignal;
        ScottPlot.Plottable.SignalPlot volumeSignal;
        ScottPlot.Plottable.SignalPlot leftVolumeSignal;
        ScottPlot.Plottable.SignalPlot rightVolumeSignal;
        ScottPlot.Plottable.SignalPlot flowSignal;


        public PlotDisplay()
        {
            InitializeComponent();
        }

        private void PlotDisplay_Load(object sender, EventArgs e)
        {
            pressurePlot.Plot.XAxis.TickLabelFormat("0.000", false);
            pressurePlot.Plot.XAxis.LabelStyle(fontSize: 10);
            //pressurePlot.Plot.SetAxisLimitsX(0.0, 10.0);
            pressurePlot.Plot.XLabel("Time (s)");

            pressurePlot.Plot.YAxis.TickLabelFormat("0.00", false);
            pressurePlot.Plot.YAxis.LabelStyle(fontSize: 10);
            //pressurePlot.Plot.SetAxisLimitsY(0.0, 120.0);
            pressurePlot.Plot.YLabel("Airway Pressure (cmH2O)");

            pressurePlot.Plot.YAxis2.TickLabelFormat("0.00", false);
            pressurePlot.Plot.YAxis2.Ticks(true);
            //pressurePlot.Plot.SetAxisLimits(yMin: 0.0, yMax: 120.0, yAxisIndex: 1);
            pressurePlot.Plot.YAxis2.LabelStyle(fontSize: 10);
            pressurePlot.Plot.YAxis2.Label("Lung Pressure (cmH2O)");
            pressurePlot.Plot.YAxis2.Edge = ScottPlot.Renderable.Edge.Right;
            pressurePlot.Plot.YAxis2.IsVisible = true;

            volumePlot.Plot.XAxis.TickLabelFormat("0.000", false);
            volumePlot.Plot.XAxis.LabelStyle(fontSize: 10);
            //volumePlot.Plot.SetAxisLimitsX(0.0, 10.0);
            volumePlot.Plot.XLabel("Time (s)");

            volumePlot.Plot.YAxis.TickLabelFormat("0", false);
            volumePlot.Plot.YAxis.LabelStyle(fontSize: 10);
            //volumePlot.Plot.SetAxisLimitsY(0, 2000);
            volumePlot.Plot.YLabel("Volume (mL)");

            // DONE: Second Y axis doesn't seem to appear...
            volumePlot.Plot.YAxis2.TickLabelFormat("0.0", false);
            volumePlot.Plot.YAxis2.Ticks(true);
            //volumePlot.Plot.SetAxisLimits(yMin: -60.0, yMax: 60.0, yAxisIndex: 1);
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
            double[] dummyAirwayPressureData = ScottPlot.DataGen.Sin(10000, 10, 10, 5);
            double[] dummyLeftLungPressureData = ScottPlot.DataGen.Sin(10000, 10, 8, 5);
            double[] dummyRightLungPressureData = ScottPlot.DataGen.Sin(10000, 10, 4, 5);
            double[] dummyVolumeData = ScottPlot.DataGen.Cos(10000, 10, 1000, 100);
            double[] dummyLeftVolumeData = ScottPlot.DataGen.Cos(10000, 10, 400, 50);
            double[] dummyRightVolumeData = ScottPlot.DataGen.Cos(10000, 10, 600, 50);
            double[] dummyFlowData = ScottPlot.DataGen.Sin(10000, 10, 0, 20);

            int sampleRate = 500;
            airwayPressureSignal = pressurePlot.Plot.AddSignal(dummyAirwayPressureData, sampleRate, Color.Aqua, "Airway");
            leftLungPressureSignal = pressurePlot.Plot.AddSignal(dummyLeftLungPressureData, sampleRate, Color.Green, "Left");
            leftLungPressureSignal.YAxisIndex = 1;
            rightLungPressureSignal = pressurePlot.Plot.AddSignal(dummyRightLungPressureData, sampleRate, Color.Blue, "Right");
            rightLungPressureSignal.YAxisIndex = 1;

            volumeSignal = volumePlot.Plot.AddSignal(dummyVolumeData, sampleRate, Color.OrangeRed, "Total");
            leftVolumeSignal = volumePlot.Plot.AddSignal(dummyLeftVolumeData, sampleRate, Color.Orange, "Left");
            leftVolumeSignal.YAxisIndex = 0;
            rightVolumeSignal = volumePlot.Plot.AddSignal(dummyRightVolumeData, sampleRate, Color.Red, "Right");
            rightVolumeSignal.YAxisIndex = 0;

            flowSignal = volumePlot.Plot.AddSignal(dummyFlowData, sampleRate, Color.Purple, "Flow");
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
            //volumeSignal.OffsetX -= interval;
            
            //volumeSignal.MinRenderIndex += 10;
            //volumeSignal.MaxRenderIndex += 100;

            pressurePlot.Render();
            volumePlot.Render();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            testTimer.Enabled = !testTimer.Enabled;
            if (testTimer.Enabled)
            {
                startButton.Text = "Pause";
            }
            else
            {
                startButton.Text = "Start";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetDefaultAxisLimits();

            pressurePlot.Render();
            volumePlot.Render();
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
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
