using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class Order<TDelivery, TNumber, TCourier> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public TNumber Number;
        public string Description;
        public Courier ID;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        internal Order(TDelivery delivery, TNumber number, TCourier courier, string description)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
        }
    }

    abstract class Delivery
    {
        private string address;

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

    class HomeDelivery<TRecipient> : Delivery
    {
        public Recipient Recipient;

    }

    class PickPointDelivery : Delivery
    {
        
    }

    class ShopDelivery : Delivery
    {
        
    }
}
