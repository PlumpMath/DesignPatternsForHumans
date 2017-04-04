using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.FactoryMethod
{
    class Developer: Interviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asks about design patterns!");
        }
    }
}
