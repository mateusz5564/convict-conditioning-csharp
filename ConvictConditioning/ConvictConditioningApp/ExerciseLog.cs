
namespace ConvictConditioningApp
{
    public class ExerciseLog
    {
        public string Name { get; set; }
        private readonly int Lvl;
        public List<int> Reps { get; set; } = new List<int>();

        public ExerciseLog(string name, int lvl)
        {
            Name = name;
            Lvl = lvl;
        }

        public ExerciseLog(string name, int lvl, List<int> reps)
        {
            Name = name;
            Lvl = lvl;
            Reps = reps;
        }

        public string ToFileLine()
        {
            return $"{this.Name},{this.Lvl},{string.Join(",", this.Reps)}";
        }

        public static ExerciseLog FileLineToObject(string line)
        {
            var items = line.Split(",");
            var name = items[0];
            var lvl = items[1];
            var reps = items.Skip(2).Select(i => int.Parse(i)).ToList();

            return new ExerciseLog(name, int.Parse(lvl), reps);
        }
    }
}
