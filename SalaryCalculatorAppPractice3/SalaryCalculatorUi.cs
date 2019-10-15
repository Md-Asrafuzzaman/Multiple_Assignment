using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        SalaryCalculation sc=new SalaryCalculation();
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            sc.employeeName = employeeNameTextBox.Text;
            sc.basicamount =Convert.ToDouble(basicAmountTextBox.Text) ;
            int a = Convert.ToInt32(homeRentTextBox.Text);
            int b = Convert.ToInt32(medicalAllowanceTextBox.Text);
            double total = sc.HouseRentcalculate(a) + sc.MedicalAllownceCalculate(b);
            double totalsalary = sc.basicamount - total;
            MessageBox.Show(Convert.ToString(totalsalary));

        }
    }
}
