using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
     static class ExerciseFactory
    {
        public static IWorkOut GetExercise(string choice)
        {
            switch (choice.ToLower())
            {
                case "arms":
                    return new Arms();
                case "legs":
                    return new Legs();
                case "core":
                    return new Core();
                default:
                    return new GeneralWorkOut();
            }
        }
    }
}
