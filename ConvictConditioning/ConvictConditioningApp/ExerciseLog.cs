﻿
namespace ConvictConditioningApp
{
    public class ExerciseLog
    {
        public string Name { get; set; }
        public readonly int Lvl;
        public List<int> Reps { get; set; } = new List<int>();

        public ExerciseLog(string name, int lvl)
        {
            this.Name = name;
            this.Lvl = lvl;
        }

        public ExerciseLog(string name, int lvl, List<int> reps)
        {
            this.Name = name;
            this.Lvl = lvl;
            this.Reps = reps;
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
