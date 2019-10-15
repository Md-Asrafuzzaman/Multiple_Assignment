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
            //refrigetor.item.Add(Convert.ToDouble(itemTextBox.Text));
            //refrigetor.weight.Add(Convert.ToDouble(weightTextBox.Text));
            double item = Convert.ToDouble(itemTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            refrigetor.ADD_Item_and_Weight(item, weight);
            if (refrigetor.ValidationCheck())
            {
                currentWeightTextBox.Text = refrigetor.CurrentWeight().ToString();
                remainingWeightTextBox.Text = refrigetor.RemainWeight().ToString();
            }
            else
                MessageBox.Show("Current weight is greater than Maximum Weigth");

        }
    }
}
