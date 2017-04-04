using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.FactoryMethod
{
    class CommunityExecutive: Interviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about community building");
        }
    }
}
