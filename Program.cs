using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_todo_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/n=== Console Based Todo List Application");

            List<string> todoList = new List<string>();
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("/n=== Todo List Application ===");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        ViewTasks(todoList);
                        break;
                    case "2":
                        AddTask(todoList);
                        break;
                    case "3":
                        RemoveTask(todoList);
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting Loop... GoodBye");
                        break;
                    default:
                        Console.WriteLine("Invalid Option! Please Try Again");
                        Pause();
                        break;
                }
            } 
        }

        public static void ViewTasks(List<string> tasks)
        {
            Console.WriteLine("/n=== Your Todo List ===");
            if (tasks.Count < 0)
            {
                Console.WriteLine("No Task Added yet.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            Pause();
        }

        public static void AddTask(List<string> tasks)
        {
            Console.WriteLine("/n=== Enter Task Here ===");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine($"Task {task} successfully added to the list.");
            Pause();
        }

        public static void RemoveTask(List<string> tasks)
        {
            Console.WriteLine("Please Enter the number of task you want to delete");
            string Input = Console.ReadLine();

            if (int.TryParse(Input, out int index) && index > 0 && index <= tasks.Count)
            {
                string RemovedTask = tasks[index - 1];
                tasks.RemoveAt(index - 1);
                Console.WriteLine($"Task \"{RemovedTask}\" is removed Successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Task Number, Please try again");
            }
            Pause();
        }

        public static void Pause()
        {
            Console.WriteLine("/n=== Press any key to continue");
            Console.ReadKey();
        }
    }
}


    
