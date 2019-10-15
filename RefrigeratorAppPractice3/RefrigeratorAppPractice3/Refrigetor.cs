using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigetor
    {
        public double maxWeight;
        public List<int> item = new List<int>();
        public List<double> weight = new List<double>();


        public Refrigetor(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public double CW()
        {
            double cw = 0;
            for (int i = 0; i < item.Count; i++)
            {
                cw = item[i] * weight[i];
            }

            return cw;
        }

        public double RW()
        {
            return maxWeight - CW();
        }

        public bool Valid()
        {
            if (RW() > maxWeight)
            {
                return false;
            }
            return true;
        }
    }
}
