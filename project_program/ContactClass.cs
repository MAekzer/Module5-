using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    abstract class Contact
    {
        public string Name;
        public string Number;

        public virtual void ShowInfo()
        {
            Console.WriteLine("{0}\nКонтакный номер - {1}", Name, Number);
        }

        internal Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }

    abstract class Recipient : Contact
    {
        internal Recipient(string name, string number) : base(name, number) { }
    }

    class Manager : Recipient
    {
        private bool external;
        private string shopname;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Магазин {0}. ", shopname);
            if (external)
                Console.WriteLine("Менеджер сторонней компании");
            else
                Console.WriteLine("Внутренний менеджер");
        }

        public string ShopName
        {
            get { return shopname; }
            private set { shopname = value; }
        }

        public bool External
        {
            get { return external; }
            private set { external = value; }
        }

        internal Manager(string name, string number, bool external, string shopname) : base(name, number)
        {
            this.external = external;
            this.shopname = shopname;
        }
    }

    class Client : Recipient
    {
        public string? UssualPickpoint = default;
        public string? Preferences = default;

        public override void ShowInfo()
        {
            switch (UssualPickpoint, Preferences)
            {
                case (null, null):
                    base.ShowInfo();
                    break;
                case (not null, null):
                    base.ShowInfo();
                    Console.WriteLine("Чаще всего принимает заказ по адресу {0}", UssualPickpoint);
                    break;
                case (not null, not null):
                    base.ShowInfo();
                    Console.WriteLine("Чаще всего принимает заказ по адресу {0}", UssualPickpoint);
                    Console.WriteLine("Предпочтения: {0}", Preferences);
                    break;
            }
        }

        internal Client(string name, string number) : base(name, number) { }

        internal Client(string name, string number, string address)
            : this(name, number)
        {
            UssualPickpoint = address;
        }

        internal Client(string name, string number, string address, string preferences) : this(name, number, address)
        {
            Preferences = preferences;
        }
    }

    class Courier : Contact
    {
        public string Region;
        public string ID;

        public OrderList? ListOfOrders;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Курьер, работает по региону {0}. ID - {1}", Region, ID);
        }

        internal Courier(string name, string number, string ID, string region) : base(name, number)
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
            Console.WriteLine("Тип машины - {0}, номер машины - {1}", CarType, CarNumber);
        }

        internal CarCourier(string name, string number, string ID, string region, string carnum, string cartype)
            : base(name, number, ID, region)
        {
            CarNumber = carnum;
            CarType = cartype;
        }
    }
}
