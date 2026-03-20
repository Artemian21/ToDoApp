using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public TaskItem(string title)
        {
            Title = title;
            IsDone = false;
        }
    }
}
