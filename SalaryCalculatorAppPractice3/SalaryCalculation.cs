using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class SalaryCalculation
    {
        public string employeeName;
        public double basicamount=0.0;
        public double salary = 0;

        

        public double HouseRentcalculate(int a)
        {
            double hr = (basicamount * a )/ 100;
            return hr;

        }

       public  double MedicalAllownceCalculate(int a)

        {
            double ma=(basicamount* a )/ 100;
            return ma;
        }
       

    }
}
