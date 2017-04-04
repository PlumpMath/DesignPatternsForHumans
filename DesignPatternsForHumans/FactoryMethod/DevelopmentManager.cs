using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.FactoryMethod
{
    class DevelopmentManager: HiringManager
    {
        public override Interviewer makeInterviewer()
        {
            return new Developer();
        }
    }
}
