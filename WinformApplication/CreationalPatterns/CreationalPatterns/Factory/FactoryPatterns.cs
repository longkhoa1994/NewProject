using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    public interface IPizza
    {
        void Box();

        void Cut();

        void Bake();
    }
    public enum PizzaType
    {
        NewYork,
        Chicago,
        Califonia
    }
    public static class FactoryPatterns
    {
        public static IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.NewYork:
                    return new NewYorkPizza();                   
                case PizzaType.Chicago:
                    return new ChicagoPizza();
                case PizzaType.Califonia:
                    return new CalifoniaPizza();
                default:
                    return null;
            }
        }
    }
}
