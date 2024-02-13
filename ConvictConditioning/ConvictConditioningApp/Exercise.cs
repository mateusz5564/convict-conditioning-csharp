
namespace ConvictConditioningApp
{
    public class Exercise
    {
        public Exercise(string name, int lvl, string beginner, string intermediate, string progression)
        {
            this.Name = name;
            this.Lvl = lvl;
            this.Beginner = beginner;
            this.Intermediate = intermediate;
            this.Progression = progression;
        }

        public string Name { get; set; }
        public int Lvl { get; set; }
        public string Beginner { get; set; }
        public string Intermediate { get; set; }
        public string Progression { get; set; }

    }
}
