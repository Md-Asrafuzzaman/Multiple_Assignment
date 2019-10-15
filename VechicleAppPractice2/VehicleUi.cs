using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }
        Vehicle vehicle=new Vehicle();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.Name = vehicleNameTextBox.Text;
            vehicle.RegNo = regNoTextBox.Text;

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
           vehicle.speed.Add(Convert.ToDouble(speedTextBox.Text));
           speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (vehicle.CheckVehicle().Equals("true"))
            {
                maxSpeedTextBox.Text = vehicle.MaximumSpeed().ToString();
                minSpeedTextBox.Text = vehicle.MinimumSpeed().ToString();
                averageSpeedTextBox.Text = vehicle.AverageSpeed().ToString();
            }
            else
            {
                MessageBox.Show("You have no vehicle or reg");
            }
           
        }
    }
}
