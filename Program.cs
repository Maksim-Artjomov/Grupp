class Program
{
    public static void Main()
    {
        Group group = new Group(3);
        PrintResult(group.AddOpilane("John", 29, DateTime.Now));
        PrintResult(group.AddOpilane("John", 30, DateTime.Now));
        PrintResult(group.AddOpilane("Mary", 42, DateTime.Now));
        PrintResult(group.AddOpilane("Jane", 28, DateTime.Now));
        PrintResult(group.AddOpilane("Joseph", 34, DateTime.Now));
        PrintOpilased(group);

        Group bookClub = new Group(4);
        PrintResult(bookClub.AddOpilane("Albert", 29, DateTime.Now));
        PrintResult(bookClub.AddOpilane("Samantha", 21, DateTime.Now));
        PrintResult(bookClub.AddOpilane("Robert", 30, DateTime.Now));
        PrintResult(bookClub.AddOpilane("Roberta", 31, DateTime.Now));
        PrintOpilased(bookClub);

        Console.WriteLine("Albert exists in bookClub: " + bookClub.HasOpilane("Albert"));
        Console.WriteLine("John exists in bookClub: " + bookClub.HasOpilane("John"));
        Console.ReadLine();
    }

    public static void PrintResult(bool result)
    {
        if (result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("True");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("False");
        }
        Console.ResetColor();
    }

    public static void PrintOpilased(Group group)
    {
        Console.WriteLine("Opilased:");
        if (group.Liikmed.Count == 0)
        {
            Console.WriteLine("Grupis pole opilasi.");
            return;
        }
        Liik oldestOpilane = group.Liikmed[0];
        foreach (var opilane in group.Liikmed)
        {
            if (opilane.Age > oldestOpilane.Age)
            {
                oldestOpilane = opilane;
            }
        }
        foreach (var opilane in group.Liikmed)
        {
            Console.ForegroundColor = opilane == oldestOpilane ? ConsoleColor.Yellow : ConsoleColor.White;
            Console.WriteLine($"{opilane.Name}, {opilane.Age} aastat, {opilane.RegistrationDate}, {group.HasOpilane(opilane.Name)}");
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Kõige vanem opilane grupis: {oldestOpilane.Name}, {oldestOpilane.Age} aastat");
        Console.ResetColor();
    }
}