using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class GeneralWorkOut : IWorkOut
    {
        public void WorkOut()
        {
            Console.WriteLine();
            Console.WriteLine("GENERAL ROUTINE\n1: Leg Lifts\n2: Crunches" +
                "\n3: Dumbbells Curls\n4: Tricep Extensions" +
                "\n5: Lunges");
        }
    }
}
