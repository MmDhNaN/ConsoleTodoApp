using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoApp
{
    internal class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool IsCompleted { get; set; }

        public Todo(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }
}
