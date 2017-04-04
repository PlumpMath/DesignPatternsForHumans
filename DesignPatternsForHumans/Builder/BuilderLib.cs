using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.Builder
{

    class Burger
    {
        protected int Size;

        protected bool Cheese = false;
        protected bool Pepperoni = false;
        protected bool Lettuce = false;
        protected bool Tomato = false;

        public Burger(BurgerBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            Pepperoni = builder.Pepperoni;
            Lettuce = builder.Lettuce;
            Tomato = builder.Tomato;
        }
    }

    class BurgerBuilder
    {
        public int Size;
        
        public bool Cheese = false;
        public bool Pepperoni = false;
        public bool Lettuce = false;
        public bool Tomato = false;

        public void addPepperoni ()
        {
            Pepperoni = true;
        }

        public void addLettuce()
        {
            Lettuce = true;
        }

        public void addTomato()
        {
            Tomato = true;
        }

        public void addCheese()
        {
            Cheese = true;
        }

        public Burger build()
        {
            return new Burger(this);
        }

    }
}
