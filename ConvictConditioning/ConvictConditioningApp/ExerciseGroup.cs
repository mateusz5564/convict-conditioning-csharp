
namespace ConvictConditioningApp
{
    public class ExerciseGroup
    {
        protected readonly string _filename;
        public string Name { get; protected set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
        public ExerciseGroupStats ExerciseGroupStats { get; private set; }
        public ExerciseGroup(string name, string filename, List<Exercise> exercises)
        {
            this._filename = filename;
            this.Name = name;
            this.Exercises = exercises;
            ReadExerciseLogs();
            this.ExerciseGroupStats = new ExerciseGroupStats(ExerciseLogs);
        }

        public void SaveExerciseLog(ExerciseLog exerciseLog)
        {
            using (var writer = File.AppendText(this._filename))
            {
                if (exerciseLog.Reps.Count < 1)
                {
                    throw new ArgumentException("Reps list is empty!");
                }
                writer.WriteLine(exerciseLog.ToFileLine());
                ExerciseLogs.Add(exerciseLog);
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
