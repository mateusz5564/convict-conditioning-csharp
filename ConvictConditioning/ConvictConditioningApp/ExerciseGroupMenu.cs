
namespace ConvictConditioningApp
{
    public class ExerciseGroupMenu
    {
        private readonly ExerciseGroup _exerciseGroup;

        public ExerciseGroupMenu(ExerciseGroup exerciseGroup)
        {
            this._exerciseGroup = exerciseGroup;
        }

        public void StartMenu()
        {

            bool exitMenu = false;
            while (exitMenu != true)
            {
                PrintMenu();
                PrintLatestFiveLogs();

                Console.Write("Select exercise you're going to do (or b to go back): ");
                var input = Console.ReadLine();
                Console.WriteLine();

                if (input == "b") break;

                if (int.TryParse(input, out int exerciseNumber))
                {
                    if (exerciseNumber >= 1 && exerciseNumber <= 10)
                    {
                        CreateExerciseLog(exerciseNumber - 1);
                    }
                    else
                    {
                        Console.WriteLine("Select a number from 1 to 10, please");
                    }
                }
                else
                {
                    Console.WriteLine("You didn't select a number");
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine($"\n========== {_exerciseGroup.Name.ToUpper()} ==========\n");
            Console.WriteLine("The list of all exercises: \n");
            PrintExercises();
        }

        private void PrintExercises()
        {
            for (int i = 0; i < _exerciseGroup.Exercises.Count; i++)
            {
                var exercise = _exerciseGroup.Exercises[i];
                Console.WriteLine($"{i + 1}. {exercise.Name} -> beginner: {exercise.Beginner}, intermediate: {exercise.Intermediate}, progression: {exercise.Progression}");
            }
            Console.WriteLine();
        }

        private void CreateExerciseLog(int exerciseIndex)
        {
            var exercise = this._exerciseGroup.Exercises[exerciseIndex];
            Console.WriteLine($"You chose {exercise.Name}: {exercise.Beginner} -> {exercise.Intermediate} -> {exercise.Progression}");

            var exerciseLog = new ExerciseLog(exercise.Name, exercise.Lvl);

            while (true)
            {
                Console.WriteLine("Enter s to save entry or q to cancel");
                Console.Write("Number of reps: ");
                var input = Console.ReadLine();

                if (input == "q") break;

                if (input == "s")
                {
                    try
                    {
                        this._exerciseGroup.SaveExerciseLog(exerciseLog);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                }

                if (int.TryParse(input, out int reps))
                {
                    exerciseLog.Reps.Add(reps);
                }
                else
                {
                    Console.WriteLine("It's not a number");
                }
            }
        }

        private void PrintLatestFiveLogs()
        {
            var logs = _exerciseGroup.ExerciseGroupStats.GetLatestFiveLogs();

            Console.WriteLine("Latest exercise logs: ");
            foreach (var log in logs)
            {
                Console.WriteLine($"{log.Name} (lvl {log.Lvl}) -> {String.Join(" ", log.Reps)}");
            }

            Console.WriteLine();
        }
    }
}
