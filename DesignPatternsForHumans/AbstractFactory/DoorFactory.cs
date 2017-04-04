using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.AbstractFactory
{
    interface DoorFactory
    {
        Door makeDoor();
        DoorFittingExpert makeFittingExpert();
    }
}
