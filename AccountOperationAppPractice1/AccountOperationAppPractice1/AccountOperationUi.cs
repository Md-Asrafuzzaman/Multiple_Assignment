using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account aAccount = new Account();

        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            aAccount.accountNumber = accountNoTextBox.Text;
            aAccount.customerName = customerNameTextBox.Text;
            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(aAccount.accountNumber) && !String.IsNullOrEmpty(aAccount.customerName))
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aAccount.DepositAmount(amount);
                amountTextBox.Clear();
            }
            else
                MessageBox.Show("Invalid Account");

            
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(aAccount.accountNumber) && !String.IsNullOrEmpty(aAccount.customerName))
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aAccount.WithdrawAmount(amount);
                amountTextBox.Clear();
            }
            else
                MessageBox.Show("Invalid Account");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(aAccount.accountNumber) && !String.IsNullOrEmpty(aAccount.customerName))
            {
                string bankReport = aAccount.customerName + "  Your Account Number : "
               + aAccount.accountNumber + "  Your Account Balance :  " +
                        aAccount.balance;
                MessageBox.Show(bankReport);
            }     
        }
    }
}
