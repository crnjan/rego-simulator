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

            radiatorReturnNumericUpDown.DataBindings.Add("Value", registers, "RadiatorReturn", true, DataSourceUpdateMode.OnPropertyChanged);
            outdoorNumericUpDown.DataBindings.Add("Value", registers, "Outdoor", true, DataSourceUpdateMode.OnPropertyChanged);
            hotWaterNumericUpDown.DataBindings.Add("Value", registers, "HotWater", true, DataSourceUpdateMode.OnPropertyChanged);
            forwardNumericUpDown.DataBindings.Add("Value", registers, "Forward", true, DataSourceUpdateMode.OnPropertyChanged);
                
            simulator = new RegoServer(RegoMapper.CreateRego600Mapper(registers));
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
