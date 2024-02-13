
namespace ConvictConditioningApp
{
    public static class ExercisesLists
    {
        public static readonly List<Exercise> Pushups = new List<Exercise>
        {
            new Exercise("Wall Pushups", 1, "1x10", "2x25", "3x50"),
            new Exercise("Incline Pushups", 2, "1x10", "2x20", "3x40"),
            new Exercise("Kneeling Pushups", 3, "1x10", "2x15", "3x30"),
            new Exercise("Half Pushups", 4, "1x8", "2x12", "3x25"),
            new Exercise("Full Pushups", 5, "1x5", "2x10", "3x20"),
        };
        public static readonly List<Exercise> Squats = new List<Exercise>
        {
            new Exercise("Shoulderstand Squats", 1, "1x10", "2x25", "3x50"),
            new Exercise("Jacknife Squats", 2, "1x10", "2x20", "3x40"),
            new Exercise("Supported Squats", 3, "1x10", "2x15", "3x30"),
            new Exercise("Half Squats", 4, "1x8", "2x35", "2x50"),
            new Exercise("Full Squats", 5, "1x5", "2x10", "2x30"),
        };
        public static readonly List<Exercise> Pullups = new List<Exercise>
        {
            new Exercise("Vertical Pullups", 1, "1x10", "2x20", "3x40"),
            new Exercise("Horizontal Pullups", 2, "1x10", "2x20", "3x30"),
            new Exercise("Jacknife Pullups", 3, "1x10", "2x15", "3x20"),
            new Exercise("Half Pullups", 4, "1x8", "2x11", "2x15"),
            new Exercise("Full Pullups", 5, "1x5", "2x8", "2x10"),
        };
        public static readonly List<Exercise> LegRaises = new List<Exercise>
        {
            new Exercise("Knee Tucks Leg Raises", 1, "1x10", "2x25", "3x40"),
            new Exercise("Flat Knee Leg Raises", 2, "1x10", "2x20", "3x35"),
            new Exercise("Flat Bent Leg Raises", 3, "1x10", "2x15", "3x30"),
            new Exercise("Flat Forg Raises", 4, "1x8", "2x15", "3x25"),
            new Exercise("Flat Straight Raises", 5, "1x5", "2x10", "2x20"),
        };
        public static readonly List<Exercise> Bridges = new List<Exercise>
        {
            new Exercise("Short Bridges", 1, "1x10", "2x25", "3x50"),
            new Exercise("Straight Bridges", 2, "1x10", "2x20", "3x40"),
            new Exercise("Angled Bridges", 3, "1x10", "2x15", "3x30"),
            new Exercise("Head Bridges", 4, "1x8", "2x15", "2x25"),
            new Exercise("Half Bridges", 5, "1x8", "2x15", "2x20"),
        };
        public static readonly List<Exercise> HandstandPushups = new List<Exercise>
        {
            new Exercise("Wall Headstand Pushups", 1, "30sec", "1min", "2min"),
            new Exercise("Crow Stands Handstand Pushups", 2, "10sec", "30sec", "1min"),
            new Exercise("Wall Handstand Pushups", 3, "30sec", "1min", "2min"),
            new Exercise("Half Handstand Pushups", 4, "1x5", "2x10", "2x20"),
            new Exercise("Handstand Pushups", 5, "1x5", "2x10", "2x15"),
        };
    }
}
