using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.AbstractFactory
{
    class IronDoor : Door
    {
        public void getDescription()
        {
            Console.WriteLine("I am an iron door");
        }
    }

    class WoodenDoor : Door
    {
        public void getDescription()
        {
            Console.WriteLine("I am a wooden door.");
        }
    }

    class Welder : DoorFittingExpert
    {
        public void getDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }

    class Carpenter : DoorFittingExpert
    {
        public void getDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }

    class WoodenDoorFactory : DoorFactory
    {
        public Door makeDoor()
        {
            return new WoodenDoor();
        }

        public DoorFittingExpert makeFittingExpert()
        {
            return new Carpenter();
        }
    }

    class IronDoorFactory : DoorFactory
    {
        public Door makeDoor()
        {
            return new IronDoor();
        }

        public DoorFittingExpert makeFittingExpert()
        {
            return new Welder();
        }
    }
    

    }

