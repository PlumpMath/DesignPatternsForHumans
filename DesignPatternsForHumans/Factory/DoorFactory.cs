using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.Factory
{
    public class DoorFactory
    {
        //This is the dedicated Factory class that creates new Wooden Doors.
        public static WoodenDoor makeDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
