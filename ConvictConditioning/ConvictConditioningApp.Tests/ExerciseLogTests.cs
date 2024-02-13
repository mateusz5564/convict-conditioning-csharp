namespace ConvictConditioningApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenExerciseLogConvertedToFileString_ShouldGetCorrectString()
        {
            var exerciseLog = new ExerciseLog("Wall Pushups", 1, new List<int> { 7, 7, 6 });

            var fileLine = exerciseLog.ToFileLine();

            Assert.AreEqual(fileLine, "Wall Pushups,1,7,7,6");
        }

        [Test]
        public void WhenFileLineConvertedToObject_ShouldGetCorrectObject()
        {
            var fileLine = "Wall Pushups,1,7,7,6";
            var generatedObj = ExerciseLog.FileLineToObject(fileLine);

            var exerciseLog = new ExerciseLog("Wall Pushups", 1, new List<int> { 7, 7, 6 });
            Assert.AreEqual(exerciseLog.Name, generatedObj.Name);
            Assert.AreEqual(exerciseLog.Lvl, generatedObj.Lvl);
            Assert.IsTrue(exerciseLog.Reps.SequenceEqual(generatedObj.Reps));
        }
    }
}