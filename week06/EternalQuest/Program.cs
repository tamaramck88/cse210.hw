GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine($"Score: {manager.GetScore()}");
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");

    Console.Write("Select: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Create goal logic
            break;

        case "2":
            manager.DisplayGoals();
            break;

        case "3":
            manager.DisplayGoals();
            Console.Write("Goal Number: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            manager.RecordEvent(index);
            break;

        case "4":
            // Save logic
            break;

        case "5":
            // Load logic
            break;

        case "6":
            running = false;
            break;
    }
}