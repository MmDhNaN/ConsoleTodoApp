Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("""
=========================
        TODO APP
=========================
""");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("1.");
Console.ResetColor();
Console.WriteLine(" Add Task");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("2.");
Console.ResetColor();
Console.WriteLine(" Show Tasks");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("3.");
Console.ResetColor();
Console.WriteLine(" Complete Task");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("4.");
Console.ResetColor();
Console.WriteLine(" Delete Task");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("0.");
Console.ResetColor();
Console.WriteLine(" Exit");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nChoose an option: ");
Console.ResetColor();

string? choice = Console.ReadLine();
