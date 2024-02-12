using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
