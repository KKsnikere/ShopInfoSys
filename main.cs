using System;
using System.IO;

namespace ShopUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 105));
            Console.WriteLine("ONLINE SHOP INFORMATION AND REFERENCE SYSTEM");
            Console.WriteLine(new string('-', 105));
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Choose file: ");
                Console.WriteLine("1. Clients");
                Console.WriteLine("2. Items");
                Console.WriteLine("3. Orders");
                Console.WriteLine("4. Exit program");
                Console.Write("Enter file number: ");
                string fileChoice = Console.ReadLine();
                Console.WriteLine(new string('-', 105));

                switch (fileChoice)
                {
                case "1":
                    CustomersMenu();
                    break;
                case "2":
                    ProductsMenu();
                    break;
                case "3":
                    OrdersMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid file selection. Please try again.\n");
                    break;
                }
            }
        }

        static void CustomersMenu()
        {
            string filename = "klienti.txt";

            while (true)
            {
                Console.WriteLine("\nChoose option: ");
                Console.WriteLine("1. Show clients");
                Console.WriteLine("2. Add client");
                Console.WriteLine("3. Back to file selection");
                Console.WriteLine("4. Close program");
                Console.Write("Enter action number: ");
                string choice = Console.ReadLine();
                Console.WriteLine(new string('-', 105));

                switch (choice)
                {
                    case "1":
                        DataPrinter.PrintData(filename);
                        break;
                    case "2":
                        AddData.AddClientData(filename);
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid action choice. Please try again.\n");
                        break;
                }
            }
        }

        static void ProductsMenu()
        {
            string filename = "preces.txt";

            while (true)
            {
                Console.WriteLine("\nChoose option: ");
                Console.WriteLine("1. Show products");
                Console.WriteLine("2. Add product");
                Console.WriteLine("3. Back to file selection");
                Console.WriteLine("4. Close program");
                Console.Write("Enter action number: ");
                string choice = Console.ReadLine();
                Console.WriteLine(new string('-', 105));

                switch (choice)
                {
                    case "1":
                        DataPrinter.PrintData(filename);
                        break;
                    case "2":
                        AddData.AddItemData(filename);
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid action choice. Please try again.\n");
                        break;
                }
            }
        }

        static void OrdersMenu()
        {
            string filename = "pasutijumi.txt";

            while (true)
            {
                Console.WriteLine("\nChoose option: ");
                Console.WriteLine("1. Show orders");
                Console.WriteLine("2. Add order");
                Console.WriteLine("3. Back to file selection");
                Console.WriteLine("4. Close program");
                Console.Write("Enter action number: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DataPrinter.PrintData(filename);
                        break;
                    case "2":
                        AddData.AddOrderData(filename);
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid action choice. Please try again.\n");
                        break;
                }
            }
        }
    }
}