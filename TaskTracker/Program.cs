namespace TaskTracker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            // Welcome user
            // 1 add task
            // 2 view all task
            // 3 Mark task complete
            // 4 Remove task
            // 5 Exit
            Console.WriteLine("welcome to my task tracker");
            Console.WriteLine("-----------------");
            while (true)
                {
                Console.WriteLine("Enter your choice  from 1 to 5");
                Console.WriteLine("1 = add task");
                Console.WriteLine("2 = view all tasks");
                Console.WriteLine("3 = Mark task complete");
                Console.WriteLine("4 = Remove task");
                Console.WriteLine("5 = Exit");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        // add task
                        AddTask();
                        break;
                    case "2":
                        // view all tasks
                        viewTasks();
                        break;
                    case "3":
                        // Mark task complete
                        MarkComplete();
                        break;
                    case "4":
                        // Remove task
                        DeleteTask();
                        break;
                    case "5":
                        // Exit
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("please inter number from 1 to 5 only");
                        break;
                }
            }

            


        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task title");
            string taskTitle = Console.ReadLine();

            tasks[taskIndex] = taskTitle;
            Console.WriteLine("Task Added");
            taskIndex++;
        }

        private static void viewTasks()
        {
            Console.WriteLine("Task list :");
            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i+1} Task list: {tasks[i]}");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter task number");

            string taskNumber = Console.ReadLine();

            int taskId = Convert.ToInt32(taskNumber);

            tasks[taskId] = tasks[taskId] + "--Completed";
        }

        private static void DeleteTask()
        {
            Console.WriteLine("Enter task number to delete");

            string taskNumber = Console.ReadLine();

            int taskId = Convert.ToInt32(taskNumber);

            tasks[taskId] = string.Empty;
        }
    }
}