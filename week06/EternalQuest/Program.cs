GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("=== Eternal Quest ===");
    Console.WriteLine($"Score: {manager.GetScore()}");
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

    Console.WriteLine();

    switch (choice)
    {
        case "1":

            Console.WriteLine("Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choice: ");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                manager.AddGoal(new SimpleGoal(name, desc, points));
            }
            else if (type == "2")
            {
                manager.AddGoal(new EternalGoal(name, desc, points));
            }
            else if (type == "3")
            {
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
            }

            break;

        case "2":
            manager.DisplayGoals();
            Console.WriteLine("\nPress ENTER...");
            Console.ReadLine();
            break;

        case "3":
            manager.DisplayGoals();

            Console.Write("Select goal number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            manager.RecordEvent(index);

            Console.WriteLine("\nPress ENTER...");
            Console.ReadLine();
            break;

        case "4":
            Console.Write("Filename: ");
            string saveFile = Console.ReadLine();

            manager.SaveGoals(saveFile);

            Console.WriteLine("\nPress ENTER...");
            Console.ReadLine();
            break;

        case "5":
            Console.Write("Filename: ");
            string loadFile = Console.ReadLine();

            manager.LoadGoals(loadFile);

            Console.WriteLine("\nPress ENTER...");
            Console.ReadLine();
            break;

        case "6":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            Console.ReadLine();
            break;
    }
}