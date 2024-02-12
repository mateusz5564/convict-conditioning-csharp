using ConvictConditioningApp;

Console.WriteLine("Convict Conditioning consist of 6 workout groups, each containing 5 exercises. You start with the easiest exercise, " +
    "and your goal is to get to the hardest one.\n");

Console.WriteLine("List of all workout groups:");
Console.WriteLine("1. Pushups");
Console.WriteLine("2. Squats");
Console.WriteLine("3. Pullups");
Console.WriteLine("4. Leg raises");
Console.WriteLine("5. Bridges");
Console.WriteLine("6. Headstand Pushups\n");

bool exitApp = false;

while (exitApp != true)
{
    Console.Write("Select workout group (or q to exit app): ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            var pushupsGroup = new PushupsGroup();
            pushupsGroup.Menu();
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "q":
            exitApp = true;
            break;
        default: 
            Console.WriteLine("Incorrect input, (1-6) or q to quit");
            break;
    }
}


