using ConsoleTodoApp;

Console.Title = "To Do List";
List<Todo> todos = new List<Todo>();
Menu menu = new Menu();

while (true)
{
    Console.Clear();
    menu.Show();
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Clear();
            Console.Write("Please Type Your Title: ");
            string? title = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(title))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please Enter Your Title Correctly! :");
                Console.ResetColor();
                title = Console.ReadLine();
            }

            Todo todo = new Todo(title);
            todos.Add(todo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task Saved Successfully");
            Console.ResetColor();
            Thread.Sleep(800);
            break;

        case "2":
            Console.Clear();

            break;

        case "3":
            Console.Clear();

            break;

        case "4":
            Console.Clear();

            break;

        case "0":
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;
    }
}