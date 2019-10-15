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
        public List<double> item = new List<double>();
        public List<double> weight = new List<double>();


        public Refrigetor(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }
        public void ADD_Item_and_Weight(double item,double weight)
        {
            //item.Add(Convert.ToDouble(item));
            //weight.Add(Convert.ToDouble(weight));
            this.item.Add(item);
            this.weight.Add(weight);
        }
        public double CurrentWeight()
        {
            double cw = 0;
            for (int i = 0; i < item.Count; i++)
            {
                cw = item[i] * weight[i];
            }

            return cw;
        }

        public double RemainWeight()
        {
            return maxWeight - CurrentWeight();
        }

        public bool ValidationCheck()
        {
            if (CurrentWeight() < maxWeight)
            {
                return true;  
            }
            else
            {
                return false;
            }
            
        }
    }
}
