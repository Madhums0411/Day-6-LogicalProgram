using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatchProblem
    {
        public void StopWatch()
        {
            Console.WriteLine("Press Enter to start the Watch");
            Console.ReadLine();
            Console.WriteLine("Time Started");
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to stop the Watch");
            Console.ReadLine();
            Console.WriteLine("Time Stoped");
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time is =" + (Stop - Start));
        }
    }
}
