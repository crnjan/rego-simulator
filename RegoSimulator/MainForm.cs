using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegoSimulator
{
    public partial class MainForm : Form
    {
        private readonly RegoServer simulator;
        private readonly RegoRegisters registers;


        public MainForm()
        {
            InitializeComponent();

            registers = new RegoRegisters
            {
                RadiatorReturn = 26.1,
                Outdoor = -5.2,
                HotWater = 39.2,
                Forward = 30.1,
                Room = 22.7
            };
                
            simulator = new RegoServer(RegoMapper.CreateRego600Mapper(registers));

            // Sensors
            radiatorReturnNumericUpDown.DataBindings.Add("Value", registers, "RadiatorReturn", true, DataSourceUpdateMode.OnPropertyChanged);
            outdoorNumericUpDown.DataBindings.Add("Value", registers, "Outdoor", true, DataSourceUpdateMode.OnPropertyChanged);
            hotWaterNumericUpDown.DataBindings.Add("Value", registers, "HotWater", true, DataSourceUpdateMode.OnPropertyChanged);
            forwardNumericUpDown.DataBindings.Add("Value", registers, "Forward", true, DataSourceUpdateMode.OnPropertyChanged);
            roomNumericUpDown.DataBindings.Add("Value", registers, "Room", true, DataSourceUpdateMode.OnPropertyChanged);
            compressorNumericUpDown.DataBindings.Add("Value", registers, "Compressor", true, DataSourceUpdateMode.OnPropertyChanged);
            heatFluidInNumericUpDown.DataBindings.Add("Value", registers, "HeatFluidIn", true, DataSourceUpdateMode.OnPropertyChanged);
            heatFluidOutNumericUpDown.DataBindings.Add("Value", registers, "HeatFluidOut", true, DataSourceUpdateMode.OnPropertyChanged);
            coldFluidInNumericUpDown.DataBindings.Add("Value", registers, "ColdFluidIn", true, DataSourceUpdateMode.OnPropertyChanged);
            coldFluidOutNumericUpDown.DataBindings.Add("Value", registers, "ColdFluidOut", true, DataSourceUpdateMode.OnPropertyChanged);
            externalHotWaterNumericUpDown.DataBindings.Add("Value", registers, "ExternalHotWater", true, DataSourceUpdateMode.OnPropertyChanged);

            // Front panel
            frontPanelPowerCheckBox.DataBindings.Add("Checked", simulator, "FrontPanelLed1_Power", true, DataSourceUpdateMode.OnPropertyChanged);
            frontPanelPumpCheckBox.DataBindings.Add("Checked", simulator, "FrontPanelLed2_Pump", true, DataSourceUpdateMode.OnPropertyChanged);
            frontPanelAddHeatCheckBox.DataBindings.Add("Checked", simulator, "FrontPanelLed3_AdditionalHeat", true, DataSourceUpdateMode.OnPropertyChanged);
            frontPanelWaterHeatCheckBox.DataBindings.Add("Checked", simulator, "FrontPanelLed4_WaterHeat", true, DataSourceUpdateMode.OnPropertyChanged);
            frontPanelAlarmCheckBox.DataBindings.Add("Checked", simulator, "FrontPanelLed5_Alarm", true, DataSourceUpdateMode.OnPropertyChanged);

            // Error log
            lastErrorLineTextBox.DataBindings.Add("Text", simulator, "LastErrorLine", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (simulator.IsRunning)
            {
                startButton.Text = "Start";
                simulator.Stop();
            }
            else
            {
                startButton.Text = "Stop";
                simulator.Start(9265);
            }
        }
    }
}
