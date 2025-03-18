using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();

    }

    public class  BaseCoffee : ICoffee
    {
        private string _name;
        private double _price;

        public BaseCoffee(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string GetDescription() => _name;

        public double GetCost() => _price;
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription() => _coffee.GetDescription();
        public virtual double GetCost() => _coffee.GetCost();
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{_coffee.GetDescription()} + Milk";
        public override double GetCost() => _coffee.GetCost() + 0.5;
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{_coffee.GetDescription()} + Sugar";
        public override double GetCost() => _coffee.GetCost() + 0.5;
    }

}
