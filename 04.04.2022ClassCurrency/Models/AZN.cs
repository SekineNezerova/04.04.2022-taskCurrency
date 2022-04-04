using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2022ClassCurrency.Models
{
   public class AZN
    {
        public double Amount { get; set; }
        public AZN(double amount)
        {
            Amount = amount;
        }
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount / 1.7);
        }
        public static implicit operator AZN(EURO euro)
        {
            return new AZN(euro.Amount/0.54);
        }
        public static bool operator <(AZN a,EURO e)
        {
            return a.Amount < e.Amount*0.54;
        }
        public static bool operator >(AZN a, EURO e)
        {
            return a.Amount > e.Amount*0.54;
        }
        public static bool operator <(AZN a, USD u)
        {
            return a.Amount < u.Amount * 1.7;
        }
        public static bool operator >(AZN a, USD u)
        {
            return a.Amount > u.Amount * 1.7;
        }


    }
}
