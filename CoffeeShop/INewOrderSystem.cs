using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class oldOrderSystem
    {
        public string PlaceOrder(string details)
        {
            return $"[OLD SYSTEM] order placed: {details}";
        }

        public interface INewOrderSystem
        {
            string ProcessOrder(ICoffee coffee);
        }

        public class  OrderAdapter : INewOrderSystem
        {
            private readonly oldOrderSystem _oldOrderSystem = new oldOrderSystem(); 

            public string ProcessOrder(ICoffee coffee)
            {
                string orderDetails = coffee.GetDescription() + "_ Cost: R" + coffee.GetCost();
                return _oldOrderSystem.PlaceOrder(orderDetails);
            }
        }
    }
}
