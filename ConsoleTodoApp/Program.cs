using ConsoleTodoApp;
using System.Drawing;

Console.Title = "To Do List";
List<Todo> todos = new List<Todo>();
Menu menu = new Menu();
int nextId = 1;
string completedStatus = " ";
string colorName = " ";

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
            todo.Id = nextId;
            nextId++;
            todos.Add(todo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task Saved Successfully");
            Console.ResetColor();
            Thread.Sleep(800);
            break;

        case "2":
            Console.Clear();
            foreach (Todo todolist in todos)
            {
                if (todolist.IsCompleted == true)
                {
                    completedStatus = "Completed";
                    colorName = "Green";
                }
                else
                {
                    completedStatus = "Not Completed";
                    colorName = "Red";
                }
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(colorName);
                Console.WriteLine(todolist.Id + " - " +todolist.Title + " - " + completedStatus);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress Any Key To Return...");
            Console.ResetColor();
            Console.ReadKey();
            break;

        case "3":
            Console.Clear();
            int taskId;
            foreach (Todo todolist in todos)
            {
                if (todolist.IsCompleted == true)
                {
                    completedStatus = "Completed";
                    colorName = "Green";
                }
                else
                {
                    completedStatus = "Not Completed";
                    colorName = "Red";
                }
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(colorName);
                Console.WriteLine(todolist.Id + " - " + todolist.Title + " - " + completedStatus);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("""
                Enter Task ID To Complete Task!
                Press 0 To Return:
                """);
            Console.ResetColor();





            while (true)
            {

                string? input = Console.ReadLine();
                if (int.TryParse(input, out taskId))
                    break;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Your Task ID Correctly!");
                Console.ResetColor();
            }
            if (taskId == 0)
            {
                Console.Clear();

                break;
            }
            else
            {
                var result = todos.FirstOrDefault(i => i.Id == taskId);
                if (result != null)
                {
                    result.IsCompleted = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Task Not Found!");
                    Console.ResetColor();
                }
            }

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