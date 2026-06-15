GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("=== Eternal Quest ===");
    Console.WriteLine();

    Console.WriteLine($"Current Score: {manager.GetScore()}");

    // Creativity Feature
    if (manager.GetScore() >= 1000)
    {
        Console.WriteLine("Rank: Master Adventurer");
    }
    else if (manager.GetScore() >= 500)
    {
        Console.WriteLine("Rank: Adventurer");
    }
    else if (manager.GetScore() >= 100)
    {
        Console.WriteLine("Rank: Explorer");
    }
    else
    {
        Console.WriteLine("Rank: Beginner");
    }

    Console.WriteLine();
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");
    Console.WriteLine();

    Console.Write("Select an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            Console.WriteLine();
            Console.WriteLine("Goal Types:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Select Goal Type: ");
            string goalType = Console.ReadLine();

            Console.Write("Goal Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "1")
            {
                manager.AddGoal(
                    new SimpleGoal(
                        name,
                        description,
                        points
                    )
                );
            }
            else if (goalType == "2")
            {
                manager.AddGoal(
                    new EternalGoal(
                        name,
                        description,
                        points
                    )
                );
            }
            else if (goalType == "3")
            {
                Console.Write("Target Count: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        targetCount,
                        bonus
                    )
                );
            }

            break;

        case "2":

            Console.WriteLine();
            manager.DisplayGoals();

            break;

        case "3":

            Console.WriteLine();
            manager.DisplayGoals();

            Console.Write("Goal Number: ");
            int goalNumber = int.Parse(Console.ReadLine());

            manager.RecordEvent(goalNumber - 1);

            break;

        case "4":

            Console.Write("Filename: ");
            string saveFile = Console.ReadLine();

            manager.SaveGoals(saveFile);

            break;

        case "5":

            Console.Write("Filename: ");
            string loadFile = Console.ReadLine();

            manager.LoadGoals(loadFile);

            break;

        case "6":

            running = false;

            break;

        default:

            Console.WriteLine("Invalid option.");

            break;
    }

    if (running)
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}