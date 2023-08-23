namespace Module_1
{
    internal class Program
    {
        static TaskItem[] tasks = new TaskItem[100];
        static int taskCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! It's your personal To-Do List App!");

            while (true)
            {
                Console.WriteLine("\nAvailable commands:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Mark as");
                Console.WriteLine("4. Show");
                Console.WriteLine("5. Exit");

                Console.Write("Enter a command (number or name of the command: ");
                string? command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "Add item":
                    case "1":
                        AddItem();
                        break;

                    case "Remove item":
                    case "2":
                        RemoveItem();
                        break;

                    case "Mark as":
                    case "3":
                        MarkAs();
                        break;

                    case "Show":
                    case "4":
                        Show();
                        break;

                    case "Exit":
                    case "5":
                        Console.WriteLine("Thanks for using me! Goodbye!"); ;
                        return;

                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }

            static void AddItem()
            {
                Console.WriteLine("Enter your task: ");
                string? taskName = Console.ReadLine();

                if (taskName != null && !TaskExists(taskName))
                {
                    tasks[taskCount++] = new TaskItem{ Task = taskName, Completed = false };
                    Console.WriteLine("Task added successfully");
                }
                else
                {
                    Console.WriteLine("Task already exists.");
                }
            }

            static void RemoveItem()
            {
                Console.WriteLine("Enter task you want to remove: ");
                string? taskName = Console.ReadLine();

                if (taskName != null)
                {
                    int taskIndex = FindTaskIndex(taskName);

                    if (taskIndex != -1)
                    {
                        ShiftArrayLeft(taskIndex);
                        taskCount--;
                        Console.WriteLine("Your task was removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Task not found");
                    }
                }
            }

            static void MarkAs()
            {
                Console.WriteLine("Enter status (1 for completed, 0 for not completed): ");
                if (int.TryParse(Console.ReadLine(), out int status) && (status == 0 || status == 1))
                {
                    Console.WriteLine("Enter task: ");
                    string? taskName = Console.ReadLine();

                    if (taskName != null)
                    {
                        int taskIndex = FindTaskIndex(taskName);

                        if (taskIndex != -1)
                        {
                            tasks[taskIndex].Completed = status == 1;
                            tasks[taskIndex].CompletionDate = status == 1 ? DateTime.Now : DateTime.Now;
                            Console.WriteLine("Task marked as completed.");
                        }
                        else
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid status value.");
                }
            }

            static void Show()
            {
                Console.WriteLine("Enter status (1 for completed, 0 for not completed, enter for all");
                string? statusInput = Console.ReadLine();

                if(string.IsNullOrEmpty(statusInput))
                {
                    for(int i = 0; i < taskCount; i++)
                    {
                        Console.WriteLine($"Task: {tasks[i].Task} " +
                                          $"| Status: {(tasks[i].Completed ? "Completed" : "Not Completed")} " +
                                          $"| Completion Date: {tasks[i].CompletionDate}");
                    }
                }
                else if (int.TryParse(statusInput, out int status) && (status == 0 || status == 1))
                {
                    for(int i = 0; i<taskCount; i++)
                    {
                        if (tasks[i].Completed == (status == 1))
                        {
                            Console.WriteLine($"Task: {tasks[i].Task} " +
                                              $"| Status: {(tasks[i].Completed ? "Completed" : "Not Completed")} " +
                                              $"| Completion Date: {tasks[i].CompletionDate}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid status value.");
                }
            }

            static bool TaskExists(string taskName)
            {
                for(int i = 0; i < taskCount; i++)
                {
                    if (tasks[i].Task.Equals(taskName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }

            static int FindTaskIndex(string taskName)
            {
                for(int i = 0; i< taskCount; i++)
                {
                    if (tasks[i].Task.Equals (taskName, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }
                }
                return -1;
            }

            static void ShiftArrayLeft(int index)
            {
                for(int i = index; i < taskCount - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                tasks[taskCount - 1] = null;
            }
        }
    }
}