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
            var pushupsGroup = new ExerciseGroup("Pushups", "pushups.txt", ExercisesLists.Pushups);
            var pushupsGroupMenu = new ExerciseGroupMenu(pushupsGroup);
            pushupsGroupMenu.StartMenu();
            break;
        case "2":
            var squatsGroup = new ExerciseGroup("Squats", "squats.txt", ExercisesLists.Squats);
            var squatsGroupMenu = new ExerciseGroupMenu(squatsGroup);
            squatsGroupMenu.StartMenu();
            break;
        case "3":
            var pullupsGroup = new ExerciseGroup("Pullups", "pullups.txt", ExercisesLists.Pullups);
            var pullupsGroupMenu = new ExerciseGroupMenu(pullupsGroup);
            pullupsGroupMenu.StartMenu();
            break;
        case "4":
            var legRaisesGroup = new ExerciseGroup("Leg Raises", "legRaises.txt", ExercisesLists.LegRaises);
            var legRaisesGroupMenu = new ExerciseGroupMenu(legRaisesGroup);
            legRaisesGroupMenu.StartMenu();
            break;
        case "5":
            var bridgesGroup = new ExerciseGroup("Bridges", "bridges.txt", ExercisesLists.Bridges);
            var bridgesGroupMenu = new ExerciseGroupMenu(bridgesGroup);
            bridgesGroupMenu.StartMenu();
            break;
        case "6":
            var handstandPushupsGroup = new ExerciseGroup("Handstand Pushups", "handstandPushups.txt", ExercisesLists.HandstandPushups);
            var handstandPushupsGroupMenu = new ExerciseGroupMenu(handstandPushupsGroup);
            handstandPushupsGroupMenu.StartMenu();
            break;
        case "q":
            exitApp = true;
            break;
        default:
            Console.WriteLine("Incorrect input, (1-6) or q to quit");
            break;
    }
}

