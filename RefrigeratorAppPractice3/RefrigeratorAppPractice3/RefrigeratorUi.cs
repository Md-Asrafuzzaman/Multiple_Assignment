using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private Refrigetor refrigetor; 

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigetor = new Refrigetor(Convert.ToDouble(maxWeightTakeTextBox.Text));
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigetor.item.Add(Convert.ToInt16(itemTextBox.Text));
            refrigetor.weight.Add(Convert.ToDouble(weightTextBox.Text));
            if (refrigetor.Valid())
            {
               currentWeightTextBox.Text= refrigetor.CW().ToString();
               remainingWeightTextBox.Text = refrigetor.RW().ToString();
            }

        }
    }
}
