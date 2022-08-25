using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Legs : IWorkOut
    {
        public void WorkOut()
        {
            Console.WriteLine();
            Console.WriteLine("LEG ROUTINE\n1: Dumbbell Split Squat\n2: Romanian Deadlift" +
                "\n3: Single-Leg RDL\n4: Goblet Squat\n5: Side Lunge\n6: Curtsy Squat");
        }
    }
}
