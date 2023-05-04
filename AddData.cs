using System;
using System.IO;

namespace ShopUsers
{
    class AddData
    {
        public static void AddClientData(string filename)
        {
            // Ask user for input
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();

            // Write data to file
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.Write($"{firstName}|{lastName}|{email}|{phone}|{address}\n");
                Console.WriteLine("User added to file.");
            }
        }

        public static void AddItemData(string filename)
        {
            Console.WriteLine("Enter item name:");
            string itemName = Console.ReadLine();
            Console.WriteLine("Enter item price:");
            string itemPrice = Console.ReadLine();
            Console.WriteLine("Enter item size/amount:");
            string itemSize = Console.ReadLine();
            Console.WriteLine("Enter item color:");
            string itemColor = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.Write($"{itemName}|{itemPrice}|{itemSize}|{itemColor}\n");
                Console.WriteLine("Item added to file.");
            }
        }

        public static void AddOrderData(string filename)
        {
            Console.WriteLine("Enter item name:");
            string item = Console.ReadLine();
            Console.WriteLine("Enter client name and lastname:");
            string clientName = Console.ReadLine();
            Console.WriteLine("Enter client phone number:");
            string clientPhone = Console.ReadLine();
            Console.WriteLine("Enter delivery address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter delivery date:");
            string date = Console.ReadLine();
            Console.WriteLine("Enter delivery company:");
            string company = Console.ReadLine();
            Console.WriteLine("Enter delivery status:");
            string status = Console.ReadLine();
            
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.Write($"{item}|{clientName}|{clientPhone}|{address}|{date}|{company}|{status}\n");
                Console.WriteLine("Order added to file.");
            }
        }


    }

}