using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.FactoryMethod
{
    abstract class HiringManager
    {
        abstract public Interviewer makeInterviewer();

        public void takeInterview()
        {
            Interviewer interviewer = makeInterviewer();
            interviewer.askQuestions();

        }
    }
}
