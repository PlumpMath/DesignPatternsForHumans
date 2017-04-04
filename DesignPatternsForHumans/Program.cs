using DesignPatternsForHumans.Factory;
using DesignPatternsForHumans.FactoryMethod;
using DesignPatternsForHumans.AbstractFactory;
using DesignPatternsForHumans.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternsForHumans
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void ImplementFactory ()
        {
            
            var door = Factory.DoorFactory.makeDoor(75, 150);
            Console.WriteLine($"Width: {door.getWidth()}, Height: {door.getHeight()}");
            Console.ReadKey();
        }
        public static void ImplementFactoryMethod ()
        {
            DevelopmentManager devManager = new DevelopmentManager();
            devManager.takeInterview();
            MarketingManager marketingManager = new MarketingManager();
            marketingManager.takeInterview();
            Console.ReadKey();   
        }
        public static void ImplementAbstractFactory()
        {
            WoodenDoorFactory woodenFactory = new WoodenDoorFactory();
            var door = woodenFactory.makeDoor();
            var expert = woodenFactory.makeFittingExpert();
        }
        public static void ImplementBuilder()
        {
            var burger = new BurgerBuilder();
            burger.addCheese();
            burger.addPepperoni();
            burger.build();

        }
    }
}
