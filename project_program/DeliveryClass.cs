using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    abstract class Delivery
    {
        private string address;
        private protected DateTime approxtime;
        private protected Price? price;

        public Price Price
        {
            get 
            {
                if (price != null)
                    return price;
                else
                    return new Price(0, 0);
            }
            private protected set { price = value; }
        }

        public virtual DateTime Approxtime
        {
            get { return approxtime; }
            private set { approxtime = value; }
        }

        public string Address
        {
            get { return address; }
            private set { address = value; }
        }

        internal Delivery(string address)
        {
            this.address = address;
        }
    }

    class HomeDelivery : Delivery
    {
        public Client? Recipient;
        public static readonly int ExpectedTime = 40;

        public static DateTime GetDefaultTime()
        {
            DateTime time1 = DateTime.Now;
            return time1.AddMinutes(ExpectedTime);
        }

        internal void SetDefaultTime()
        {
            approxtime = GetDefaultTime();
        }

        internal HomeDelivery(string address, int rub) : base(address)
        { 
            Price = new Price(rub);
        }

        internal HomeDelivery(string address, int rub, int kop) : base(address)
        {
            Price = new Price(rub, kop);
        }

        internal HomeDelivery(string address, int rub, int kop, Client recipient) : this(address, rub, kop)
        {
            Recipient = recipient;
        }
    }

    class PickPointDelivery<TRecipient> : Delivery where TRecipient : Recipient
    {
        public string? Description;
        public TRecipient? Recipient;
        public static readonly int ExpectedDays = 2;
        
        public static DateTime GetDefaultDay()
        {
            DateTime day1 = DateTime.Today;
            return day1.AddDays(ExpectedDays);
        }

        internal PickPointDelivery(string address) : base(address) { }

        internal PickPointDelivery(string address, TRecipient recipient) : this(address)
        {
            Recipient = recipient;
        }

        internal PickPointDelivery(string address, string description) : this(address)
        {
            Description = description;
        }

        internal PickPointDelivery(string address, string description, TRecipient recipient) : this(address, description)
        {
            Recipient = recipient;
        }
    }

    class ShopDelivery : Delivery
    {
        public string? ShopName;
        private bool external;

        public bool External
        {
            get { return external; }
            private set { external = value; }
        }

        public Price PriceCheck()
        {
            if (!External)
            {
                Price.Rub = 0;
                Price.Kop = 0;
            }
            return Price;
        }

        internal ShopDelivery(string address, string shopname, bool external) : base(address)
        {
            ShopName = shopname;
            External = external;
        }

        internal ShopDelivery(string address, string shopname, bool external, int rub) : this(address, shopname, external)
        {
            Price = new Price(rub);
        }

        internal ShopDelivery(string address, string shopname, bool external, int rub, int kop) : this(address, shopname, external)
        {
            Price = new Price(rub, kop);
        }
    }
}
