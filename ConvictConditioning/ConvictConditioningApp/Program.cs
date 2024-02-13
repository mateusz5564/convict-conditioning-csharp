using ConvictConditioningApp;

Console.WriteLine("Convict Conditioning consist of 6 workout groups, each containing 5 exercises. You start with the easiest exercise, " +
    "and your goal is to get to the hardest one.\n");

bool exitApp = false;

while (exitApp != true)
{
    Console.WriteLine("List of all workout groups:");
    Console.WriteLine("1. Pushups");
    Console.WriteLine("2. Squats");
    Console.WriteLine("3. Pullups");
    Console.WriteLine("4. Leg raises");
    Console.WriteLine("5. Bridges");
    Console.WriteLine("6. Handstand Pushups\n");
    Console.Write("Select workout group (or q to exit app): ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            StartExerciseGroupMenu("Pushups", "pushups", ExercisesLists.Pushups);
            break;
        case "2":
            StartExerciseGroupMenu("Squats", "squats", ExercisesLists.Squats);
            break;
        case "3":
            StartExerciseGroupMenu("Pullups", "pullups", ExercisesLists.Pullups);
            break;
        case "4":
            StartExerciseGroupMenu("Leg Raises", "legRaises", ExercisesLists.LegRaises);
            break;
        case "5":
            StartExerciseGroupMenu("Bridges", "bridges", ExercisesLists.Bridges);
            break;
        case "6":
            StartExerciseGroupMenu("Handstand Pushups", "handstandPushups", ExercisesLists.HandstandPushups);
            break;
        case "q":
            exitApp = true;
            break;
        default:
            Console.WriteLine("Incorrect input, (1-6) or q to quit");
            break;
    }
}

void StartExerciseGroupMenu(string groupName, string filename, List<Exercise> exerciseList)
{
    var groupFileName = $"{filename}.txt";
    var exerciseGroup = new ExerciseGroup(groupName, groupFileName, exerciseList);
    var exerciseGroupMenu = new ExerciseGroupMenu(exerciseGroup);
    exerciseGroupMenu.StartMenu();
}
