namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            while (true)
            {
                Console.WriteLine("\n1. Додати задачу");
                Console.WriteLine("2. Показати задачі");
                Console.WriteLine("3. Завершити задачу");
                Console.WriteLine("0. Вийти");

                Console.Write("Вибір: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Назва задачі: ");
                        string? title = Console.ReadLine();
                        manager.AddTask(title);
                        break;

                    case "2":
                        var tasks = manager.GetAllTasks();
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i}. {tasks[i].Title} [{(tasks[i].IsDone ? "Виконано" : " ")}]");
                        }
                        break;

                    case "3":
                        Console.Write("Номер задачі: ");
                        int index = int.Parse(Console.ReadLine());
                        manager.MarkAsDone(index);
                        break;

                    case "0":
                        return;
                }
            }
        }
    }
}