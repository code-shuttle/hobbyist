﻿using System.Collections.Generic;

namespace Todo_List_App_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> list = new List<Todo>();

            list.Add(new Todo("sample", ["1","2","3"]));
            list.Add(new Todo("sample", ["1", "2", "3"]));

            try
            {
                ShowMainScreen(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:: {ex.Message}");
            }
        }

        /// <summary>
        /// Main Screen
        /// </summary>
        /// <param name="list"></param>
        private static void ShowMainScreen(List<Todo> list)
        {
            bool completed = false;

            while (!completed)
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}\tTodo List Console App{Environment.NewLine}");

                Console.WriteLine("\t\t1:: Show Todos");
                Console.WriteLine("\t\t0:: Exit");

                Console.Write($"{Environment.NewLine}\t\t::: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.NumPad1:
                        try
                        {
                            ShowTodo(list);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error:: {ex.Message}");
                        }
                        break;
                    case ConsoleKey.NumPad0:
                        completed = true;
                        break;
                }
            } 
        }

        /// <summary>
        /// Show list of todos
        /// </summary>
        /// <param name="list"></param>
        private static void ShowTodoList(List<Todo> list)
        {
            var todoList = from t in list select t;
            int count = 1;
            Console.WriteLine($"{Environment.NewLine}\tList of Todo's{Environment.NewLine}");

            foreach (var todo in todoList)
            {
                Console.WriteLine($"\t{count++}\t{todo.Title} \t{todo.Date.Value}{Environment.NewLine}");
                foreach (var item in todo.Items)
                {
                    Console.WriteLine($"\t\t\t{item}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Show todo list
        /// </summary>
        /// <param name="list"></param>
        private static void ShowTodo(List<Todo> list)
        {
            bool completed = false;
            while (!completed)
            {
                Console.Clear();
                
                ShowTodoList(list);

                Console.WriteLine($"{Environment.NewLine}\t[1]-Add, [2]-Edit, [3]-Delete, [0]-Return");
                Console.Write($"{Environment.NewLine}\t::: ");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.NumPad1:
                        AddTodo(list);
                        break;
                    case ConsoleKey.NumPad2:
                        EditTodo(list);
                        break;
                    case ConsoleKey.NumPad3:
                        DeleteTodo(list);
                        break;
                    case ConsoleKey.NumPad0:                       
                        completed = true;
                        break;
                }
            }
        }

        private static void AddTodo(List<Todo> todos)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}\tAdd Todo{Environment.NewLine}");

                Console.Write("\t\tTitle: ");
                string title = Console.ReadLine()!;

                List<string> items = new();

                TodoItem(items);

                todos.Add(new Todo(title, items));
                Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");
                Console.Write($"\t[1]-Add Todo, [0]-Done : ");
                int inputKey = int.Parse(Console.ReadLine()!);

                if (inputKey == 1)
                {
                    continue;
                }
                else if (inputKey == 0)
                {
                    break;
                }
            }

            //Inner method for TodoItem
            static void TodoItem(List<string> items)
            {
                try
                {
                    while (true)
                    {
                        Console.Write($"{Environment.NewLine}\t\t\t:: ");
                        string item = Console.ReadLine()!;

                        items.Add(item);

                        Console.Write($"{Environment.NewLine}\t\t\t[1]-Add Todo, [0]-Done : ");

                        int inputKey = int.Parse(Console.ReadLine()!);

                        if (inputKey == 1)
                        {
                            continue;
                        }
                        else if (inputKey == 0)
                        {
                            break;
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{Environment.NewLine}\t\t\tInvalid: Input should be [1] or [0]...");
                    Console.WriteLine($"\t\t\tError: {ex.Message}");
                    Console.WriteLine($"\t\t\tExit from adding todo...");
                }
            }
        }

        private static void EditTodo(List<Todo> todos)
        {
            bool completed = false;

            while (!completed)
            {
                Console.Clear();

                ShowTodoList(todos);

                Console.Write($"{Environment.NewLine}\t[1]-Edit Todo, [0]-Return: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if ( consoleKey == ConsoleKey.NumPad0 )
                {
                    completed = true;
                    break;
                }
                else if ( consoleKey == ConsoleKey.NumPad1 )
                {
                    EditTodoItem(todos);
                }
                else
                {
                    break;
                }
            }

            //Inner method to edit a single todo
            static void EditTodoItem(List<Todo> todos)
            {
                while (true)
                {
                    Console.Write($"{Environment.NewLine}\t[Edit Todo] List Number: ");
                    int inputKey = int.Parse(Console.ReadLine()!);
                    int index = inputKey - 1;

                    Console.Clear();
                    Console.WriteLine($"{Environment.NewLine}\tEdit Todo List Number: {index + 1}");
                    Console.WriteLine($"{Environment.NewLine}\t\tUnique Id: {todos[index].Id.Value}");
                    Console.WriteLine($"{Environment.NewLine}\t\tTitle: {todos[index].Title}");
                    Console.Write("\t\t[New] Title: ");
                    string title = Console.ReadLine()!;

                    List<string> itemList = new();

                    foreach (var item in todos[index].Items)
                    {
                        Console.WriteLine($"{Environment.NewLine}\t\t\t[Existing text] : {item}");
                        Console.Write("\t\t\t[New text] : ");
                        string newItem = Console.ReadLine()!;

                        itemList.Add(newItem);
                    }

                    todos[index].Title = title;
                    todos[index].Items = itemList;

                    Console.Write($"{Environment.NewLine}\t[0]-Return: ");
                    ConsoleKey consoleKey = Console.ReadKey().Key;

                    if (consoleKey == ConsoleKey.NumPad0)
                    {
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void DeleteTodo(List<Todo> todos)
        {
            bool completed = false;

            while (!completed)
            {
                Console.Clear();

                ShowTodoList(todos);

                Console.Write($"{Environment.NewLine}\t[1]-Delete Todo, [0]-Return: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.NumPad0)
                {
                    completed = true;
                    break;
                }
                else if (consoleKey == ConsoleKey.NumPad1)
                {
                    DeleteTodoItem(todos);
                }
                else
                {
                    break;
                }
            }

            //Inner method to delete a single todo
            static void DeleteTodoItem(List<Todo> todos)
            {
                Console.Write($"{Environment.NewLine}\t[Delete Todo] List Number: ");
                int inputKey = int.Parse(Console.ReadLine()!);
                int index = inputKey - 1;

                //todos.Remove(todos[index]);
                todos.RemoveAt(index);
            }
        }
    }
}
