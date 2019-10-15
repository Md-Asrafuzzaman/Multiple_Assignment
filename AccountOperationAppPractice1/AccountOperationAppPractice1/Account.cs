using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance = 0.0;
        
        public double DepositAmount(double amount)
        {
            balance = balance + amount;
            return balance;
        }

       public double WithdrawAmount(double amount)
        {
            balance = balance - amount;
            return balance; 
        }

       //public void ReportGenerate()
       //{
           
       //}

    }
}
