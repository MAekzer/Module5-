using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    abstract class Contact
    {
        public (string FirstName, string LastName, string ContactNumber) Info;

        public virtual void ShowInfo()
        {
            Console.WriteLine("{0} {1}\nКонтакный номер - {2}", Info.FirstName, Info.LastName, Info.ContactNumber);
        }

        internal Contact((string FirstName, string LastName, string ContactNumber) info)
        {
            Info = info;
        }
    }

    abstract class Recipient : Contact
    {


        internal Recipient((string FirstName, string LastName, string ContactNumber) info) : base(info)
        {

        }
    }

    class Courier : Contact
    {
        public string Region;
        public string ID;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Курьер, работает по региону {0}. ID - {1}", Region, ID);
        }

        internal Courier((string FirstName, string LastName, string ContactNumber) info,
            string ID,
            string region)
            : base(info)
        {
            Region = region;
            this.ID = ID;
        }
    }

    class CarCourier : Courier
    {
        public string CarNumber;
        public string CarType;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Номер машины - {0}", CarNumber);
        }

        internal CarCourier((string FirstName, string LastName, string ContactNumber) info,
            string ID,
            string region,
            string carnum,
            string carType)
            : base(info, ID, region)
        {
            CarNumber = carnum;
            CarType = carType;
        }
    }
}
