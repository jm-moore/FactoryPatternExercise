using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Core : IWorkOut
    {
        public void WorkOut()
        {
            Console.WriteLine();
            Console.WriteLine("CORE ROUTINE\n1: Dumbbell Swing\n2: Side Bend" +
                "\n3: Woodchop\n4: Crunch\n5: Russian Twist");
        }
    }
}
