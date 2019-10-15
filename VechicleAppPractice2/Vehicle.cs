using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
   public class Vehicle
    {
        public string Name { get; set; }
        public string RegNo { get; set; }

         public List<double>speed=new List<double>();

        public double MinimumSpeed()
        {
            return speed.Min();

        }
        public double MaximumSpeed()
        {
            return speed.Max();

        }
        public double AverageSpeed()
        {
            return speed.Average();

        }

        public bool CheckVehicle()
        {
            if (Name == "" && RegNo =="")
            {
                return false;
            }
            return true;
        }

    }
}
