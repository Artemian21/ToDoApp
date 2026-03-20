using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public void AddTask(string title)
        {
            tasks.Add(new TaskItem(title));
        }

        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }

        public void MarkAsDone(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsDone = true;
            }
        }

        public int GetTasksCount()
        {
            return tasks.Count;
        }
    }
}
