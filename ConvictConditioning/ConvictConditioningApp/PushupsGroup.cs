
namespace ConvictConditioningApp
{
    public class PushupsGroup : ExerciseGroup
    {
        public PushupsGroup() : base("pushups.txt")
        {
            this.Name = "Pushups";
            this.Exercises.Add(new Exercise("Wall Pushups", 1, "1x10", "2x25", "3x50"));
            this.Exercises.Add(new Exercise("Incline Pushups", 2, "1x10", "2x20", "3x40"));
            this.Exercises.Add(new Exercise("Kneeling Pushups", 3, "1x10", "2x15", "3x30"));
            this.Exercises.Add(new Exercise("Half Pushups", 4, "1x8", "2x12", "3x25"));
            this.Exercises.Add(new Exercise("Full Pushups", 5, "1x5", "2x10", "3x20"));
        }
    }
}
