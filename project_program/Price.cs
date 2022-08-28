using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Price
    {
        private int rub;
        private int kop;

        public void ShowPrice()
        {
            Console.WriteLine("{0} рублей, {1} копеек");
        }

        public static Price operator +(Price a, Price b)
        {
            if (a.kop + b.kop >= 100)
                return new Price
                {
                    rub = a.rub + b.rub + 1,
                    kop = a.kop + b.kop - 100,
                };
            else
                return new Price
                {
                    rub = a.rub + b.rub,
                    kop = a.kop + b.kop
                };
        }

        public static Price operator -(Price a, Price b)
        {
            if (a.kop - b.kop >= 100)
                return new Price
                {
                    rub = a.rub - b.rub - 1,
                    kop = a.kop - b.kop + 100,
                };
            else
                return new Price
                {
                    rub = a.rub - b.rub,
                    kop = a.kop - b.kop
                };
        }
    }
}
