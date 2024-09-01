namespace Customer_Listing_App_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RegularCustomer> regularCustomers = new();

            DisplayMenu(regularCustomers);
        }

        /// <summary>
        /// Display the main Menu. And will consume a list.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void DisplayMenu(List<RegularCustomer> regularCustomers)
        {
            bool isComplete = false;

            while (!isComplete)
            {
                Console.WriteLine($"Customer Listing App{Environment.NewLine}");

                Console.WriteLine("\t:: 1 - Show Customer");
                Console.WriteLine("\t:: 2 - Add Customer");
                Console.WriteLine("\t:: 3 - Edit Customer");
                Console.WriteLine("\t:: 4 - Delete Customer");
                Console.WriteLine("\t:: 0 - Exit");


                Console.Write($"{Environment.NewLine}\t:: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.NumPad1:
                        try
                        {
                            ShowCustomer(regularCustomers);
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Error:: {ex.Message}");
                        }
                        break;
                    case ConsoleKey.NumPad2:
                        try
                        {
                            AddCustomer(regularCustomers);
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Error:: {ex.Message}");
                        }
                        break;
                    case ConsoleKey.NumPad3:
                        try
                        {
                            EditCustomer(regularCustomers);
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Error:: {ex.Message}");
                        }
                        break;
                    case ConsoleKey.NumPad4:
                        try
                        {
                            DeleteCustomer(regularCustomers);
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Error:: {ex.Message}");
                        }
                        break;
                    case ConsoleKey.NumPad0:
                        isComplete = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Warning: Choose the right Menu-number...");
                        
                        break;
                }

            }
        }

        /// <summary>
        /// Display the Customer Information storage in the list.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void ShowCustomerInfo(List<RegularCustomer> regularCustomers)
        {
            Console.WriteLine($"List of Customers: {Environment.NewLine}");

            var rCustomer = from rc in regularCustomers select rc;

            int counter = 1;

            foreach (var rcustomer in rCustomer)
            {
                Console.WriteLine($"List Number: {counter++}");
                Console.WriteLine($"Id: {rcustomer.Id.Value}");
                Console.WriteLine($"Name: {rcustomer.LastName}, {rcustomer.FirstName}");
                Console.WriteLine($"Age: {rcustomer.Age}");
                Console.WriteLine($"Gender: {rcustomer.Gender}{Environment.NewLine}");
            }
        }

        /// <summary>
        /// Main Display of list of customer.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void ShowCustomer(List<RegularCustomer> regularCustomers)
        {
            while (true)
            {
                Console.Clear();

                ShowCustomerInfo(regularCustomers);

                Console.WriteLine($"{Environment.NewLine}Press Spacebar to return...");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                }
            }
        }

        /// <summary>
        /// Add new customer in the list.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void AddCustomer(List<RegularCustomer> regularCustomers)
        {    
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Add Customer{Environment.NewLine}");
                Console.Write($"\tFirst Name: ");
                string firstName = Console.ReadLine()!;
                Console.Write($"\tLast Name: ");
                string lastName = Console.ReadLine()!;
                Console.Write($"\tAge: ");
                int age = int.Parse(Console.ReadLine()!);
                Console.Write($"\tGender: ");
                string gender = Console.ReadLine()!;

                regularCustomers.Add(new RegularCustomer(firstName, lastName, age, gender));

                Console.WriteLine($"{Environment.NewLine}Press Spacebar to return or Enter to continue...");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                }
                else if (consoleKey == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
            }
        }

        /// <summary>
        /// Edit customer information.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void EditCustomer(List<RegularCustomer> regularCustomers)
        {
            while (true)
            {
                Console.Clear();
                ShowCustomerInfo(regularCustomers);

                Console.WriteLine($"{Environment.NewLine}Enter List Number you wanted to Edit...");
                Console.Write("List Number: ");
                int listNumber = int.Parse(Console.ReadLine()!);

                Console.Clear();

                var listCustomer = from lCustomer in regularCustomers select lCustomer;

                Console.WriteLine($"Edit Customer Information{Environment.NewLine}");
                Console.WriteLine($"\tName: {listCustomer.ElementAt(listNumber-1).FirstName}");
                Console.Write("\t(New) First Name: ");
                string firstName = Console.ReadLine()!;
                Console.WriteLine($"\tName: {listCustomer.ElementAt(listNumber - 1).LastName}");
                Console.Write("\t(New) Last Name: ");
                string lastName = Console.ReadLine()!;
                Console.WriteLine($"\tName: {listCustomer.ElementAt(listNumber - 1).Age}");
                Console.Write("\t(New) Age: ");
                int age = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"\tName: {listCustomer.ElementAt(listNumber - 1).Gender}");
                Console.Write("\t(New) Gender: ");
                string gender = Console.ReadLine()!;

                listCustomer.ElementAt(listNumber - 1).FirstName = firstName;
                listCustomer.ElementAt(listNumber - 1).LastName = lastName;
                listCustomer.ElementAt(listNumber - 1).Age = age;
                listCustomer.ElementAt(listNumber - 1).Gender = gender;

                Console.WriteLine($"{Environment.NewLine}Press Spacebar to return or Enter to continue...");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                } 
                else if (consoleKey == ConsoleKey.Enter)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Delete customer information in the list.
        /// </summary>
        /// <param name="regularCustomers"></param>
        private static void DeleteCustomer(List<RegularCustomer> regularCustomers)
        {
            while (true)
            {
                Console.Clear();
                ShowCustomerInfo(regularCustomers);

                Console.WriteLine($"{Environment.NewLine}Enter List Number you wanted to Delete...");
                Console.Write("List Number: ");
                int listNumber = int.Parse(Console.ReadLine()!);

                regularCustomers.RemoveAt(listNumber - 1);

                Console.Clear();
                ShowCustomerInfo(regularCustomers);

                Console.WriteLine($"{Environment.NewLine}Press Spacebar to return or Enter to continue...");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                }
                else if (consoleKey == ConsoleKey.Enter)
                {
                    continue;
                }
            }
            
        }
    }
}
