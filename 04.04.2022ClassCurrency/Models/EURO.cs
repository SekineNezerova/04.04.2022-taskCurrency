using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2022ClassCurrency.Models
{
   public class EURO
    {

        public double Amount { get; set; }
        public EURO(double amount)
        {
            Amount = amount;
        }
        public static implicit operator EURO(USD usd)
        {
            return new EURO(usd.Amount * 0.91);
        }
        public static implicit operator EURO(AZN azn)
        {
            return new EURO(azn.Amount * 0.54);
        }
        public static bool operator <(USD u, EURO e)
        {
            return u.Amount < e.Amount * 1.11;
        }
        public static bool operator >(USD u, EURO e)
        {
            return u.Amount > e.Amount * 1.11;
        }
    }
}
