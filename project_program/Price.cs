using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Price
    {
        internal int Rub;
        internal int Kop;

        public void ShowPrice()
        {
            Console.WriteLine("{0} рублей, {1} копеек", Rub, Kop);
        }

        public static Price operator +(Price a, Price b)
        {
            if (a.Kop + b.Kop >= 100)
                return new Price
                {
                    Rub = a.Rub + b.Rub + 1,
                    Kop = a.Kop + b.Kop - 100,
                };
            else
                return new Price
                {
                    Rub = a.Rub + b.Rub,
                    Kop = a.Kop + b.Kop
                };
        }

        public static Price operator -(Price a, Price b)
        {
            if (a.Kop - b.Kop >= 100)
                return new Price
                {
                    Rub = a.Rub - b.Rub - 1,
                    Kop = a.Kop - b.Kop + 100,
                };
            else
                return new Price
                {
                    Rub = a.Rub - b.Rub,
                    Kop = a.Kop - b.Kop
                };
        }

        public Price() { }

        public Price(int  rub)
        {
            Rub = rub;
        }

        public Price(int rub, int kop) : this(rub)
        {
            Kop = kop;
        }
    }
}
