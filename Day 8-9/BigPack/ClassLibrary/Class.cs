using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CostCalculator
    {
        public string CalculateCost(string minimalAmountString, string priceString)
        {
            if (minimalAmountString == "" || priceString == "")
            {
                return "0";
            }

            float minimalAmount = float.Parse(minimalAmountString);
            float price = float.Parse(priceString);
            float cost = minimalAmount * price;
            return cost.ToString();
        }
    }
}
