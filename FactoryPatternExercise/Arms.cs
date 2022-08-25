using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Arms : IWorkOut
    {
        public void WorkOut()
        {
            Console.WriteLine();
            Console.WriteLine("ARM ROUTINE\n1: Tricep Extensions\n2: Wrist Curls\n" +
                "3: Hammer Curls\n4: Overhead Press\n5: Lateral Raises");
        }
    }
}
