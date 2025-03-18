using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeShop.oldOrderSystem;

namespace CoffeeShop
{
    public class CoffeeOrderFacade
    {
        private readonly INewOrderSystem _orderSystem;

        public CoffeeOrderFacade(INewOrderSystem orderSystem)
        {
            _orderSystem = orderSystem;
        }

        public string PlaceOrder(string coffeeType, bool addMilk, bool addSugar)
        {
            ICoffee coffee = new BaseCoffee(coffeeType, 2.0);
            if (addMilk) coffee = new MilkDecorator(coffee);
            
            if (addSugar) coffee = new SugarDecorator(coffee);
            
            return _orderSystem.ProcessOrder(coffee);
        }
    }
}
