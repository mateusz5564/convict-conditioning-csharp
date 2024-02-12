
namespace ConvictConditioningApp
{
    public class ExerciseGroupStats
    {
        private readonly List<ExerciseLog> _exerciseLogs;

        public ExerciseGroupStats(List<ExerciseLog> exerciseLogs)
        {
            this._exerciseLogs = exerciseLogs;
        }

        public List<ExerciseLog> GetLatestFiveLogs()
        {
            var result = new List<ExerciseLog>();
            int count = 0;
            for (int i = _exerciseLogs.Count - 1; i >= 0; i--)
            {
                result.Add(_exerciseLogs[i]);
                count++;
                if(count >= 5)
                {
                    break;
                }
            }

            return result;
        }
    }
}
