
namespace ConvictConditioningApp
{
    public abstract class ExerciseGroup
    {
        protected readonly string _filename;
        public string Name { get; protected set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();

        public ExerciseGroup(string filename)
        {
            this._filename = filename;
            ReadExerciseLogs();
        }

        private void PrintExercises()
        {
            for (int i = 0; i < Exercises.Count; i++)
            {
                var exercise = Exercises[i];
                Console.WriteLine($"{i + 1}. {exercise.Name} -> beginner: {exercise.Beginner}, intermediate: {exercise.Intermediate}, progression: {exercise.Progression}");
            }
            Console.WriteLine();
        }

        private void PrintMenu()
        {
            Console.WriteLine($"\n========== {this.Name.ToUpper()} ==========\n");
            Console.WriteLine("The list of all exercises: \n");
            PrintExercises();
        }

        public void Menu()
        {
            bool exitMenu = false;

            while (exitMenu != true)
            {
                PrintMenu();

                Console.Write("Select exercise you're going to do (or b to go back): ");
                var input = Console.ReadLine();
                Console.WriteLine();

                if (input == "b") break;

                if (int.TryParse(input, out int exerciseNumber))
                {
                    if (exerciseNumber >= 1 && exerciseNumber <= 10)
                    {
                        AddExerciseLog(exerciseNumber - 1);
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

        private void AddExerciseLog(int exerciseIndex)
        {
            var exercise = this.Exercises[exerciseIndex];
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
                        SaveExerciseLog(exerciseLog);
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

        private void SaveExerciseLog(ExerciseLog exerciseLog)
        {
            using (var writer = File.AppendText(this._filename))
            {
                if (exerciseLog.Reps.Count < 1)
                {
                    throw new ArgumentException("Reps list is empty!");
                }
                writer.WriteLine(exerciseLog.ToFileLine());
            }
        }

        private void ReadExerciseLogs()
        {
            if (File.Exists(this._filename))
            {
                using (var reader = File.OpenText(this._filename))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var exerciseLog = ExerciseLog.FileLineToObject(line);
                        this.ExerciseLogs.Add(exerciseLog);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
