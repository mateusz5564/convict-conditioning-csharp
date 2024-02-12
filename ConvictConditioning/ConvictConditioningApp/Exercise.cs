
namespace ConvictConditioningApp
{
    public class Exercise
    {
        public Exercise(string name, int lvl, string beginner, string intermediate, string progression)
        {
            Name = name;
            Lvl = lvl;
            Beginner = beginner;
            Intermediate = intermediate;
            Progression = progression;
        }

        public string Name { get; set; }
        public int Lvl { get; set; }
        public string Beginner { get; set; }
        public string Intermediate { get; set; }
        public string Progression { get; set; }

    }
}
