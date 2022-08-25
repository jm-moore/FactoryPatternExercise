using FactoryPatternExercise;

Console.WriteLine("What area of the body do you want to exercise today?" +
    "\nPlease type: arms, legs, or core below:");

var choice = Console.ReadLine();

var workout = ExerciseFactory.GetExercise(choice);

workout.WorkOut();