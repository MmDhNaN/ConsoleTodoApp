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
                Console.Write("Please Enter Your Title Correctly: ");
                title = Console.ReadLine();
            }

            Todo todo = new Todo(title);
            todos.Add(todo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task Saved Successfully");
            Console.ResetColor();
            Thread.Sleep(800);
            Console.Clear();
            break;

        case "2":
            foreach (Todo todolist in todos)
            {
                Console.WriteLine(todolist.Title, todolist.IsCompleted);
            }
            break;

        case "3":

            break;

        case "4":

            break;

        case "0":
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;
    }
}