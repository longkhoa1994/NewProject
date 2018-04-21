using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract IPizza CreatePizza(IList<string> ingredients);

        public virtual IPizza DropPizze(IList<string> ingredients)
        {
            return new NewYorkPizza();
        }
    }

    public class NewYorkPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new NewYorkPizza();
        }
     
    }
    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new ChicagoPizza();
        }
        public override IPizza DropPizze(IList<string> ingredients)
        {
            return new ChicagoPizza();
        }
    }
}
