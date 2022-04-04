using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2022ClassCurrency.Models
{
   public class USD
    {

        public double Amount { get; set; }
        public USD(double amount)
        {
            Amount = amount;
        }
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount * 1.7);
        }
        public static implicit operator USD(EURO euro)
        {
            return new USD(euro.Amount / 0.91);
        }
    }
}
