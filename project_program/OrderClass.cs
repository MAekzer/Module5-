using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public int Number;
        public string Description;
        public string? CourierID;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        internal Order(TDelivery delivery, int number, string description)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
        }

        internal Order(TDelivery delivery, int number, string ID, string description) : this(delivery, number, description)
        {
            CourierID = ID;
        }
    }

    class OrderList
    {
        public List<Order<Delivery>> Orders;

        public Order<Delivery> this[int number]
        {
            get
            {
                foreach (Order<Delivery> O in Orders)
                {
                    if (number == O.Number)
                        return O;
                }
                return null;
            }
            set
            {
                    if (number >= 0 && number < Orders.Count)
                        Orders[number] = value;
                    else if (number == Orders.Count)
                        Orders.Add(value);
            }
        }

        public void AddOrder(Order<Delivery> order)
        {
            Orders.Add(order);
        }

        public OrderList(List<Order<Delivery>> orders)
        {
            Orders = orders;
        }
    }
}
