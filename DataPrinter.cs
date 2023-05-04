using System;
using System.IO;

namespace ShopUsers
{
    class DataPrinter
    {
        /// <summary>
        /// Reads data from file and prints it as a table
        /// </summary>
        /// <param name="filename">The name of the file to read from</param>
        public static void PrintData(string filename)
        {
            try
            {
            
                // Open the file for reading
                using (StreamReader sr = new StreamReader(filename))
                {
                    if(filename=="klienti.txt")
                    {
                        // Print the table header
                        Console.WriteLine("{0,-20} {1,-20} {2,-40} {3,-15} {4,-30}", "First Name", "Last Name", "Email", "Phone number", "Address");
                        Console.WriteLine(new string('-', 105));

                        // Read each line of the file and print as table row
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] userData = line.Split('|');
                            Console.WriteLine("{0,-20} {1,-20} {2,-40} {3,-15} {4,-30}", userData[0], userData[1], userData[2], userData[3], userData[4]);
                        }
                    }
                
                    else if(filename=="preces.txt")
                    {
                        Console.WriteLine("{0,-35} {1,-15} {2,-25} {3,-20}", "Name", "Price", "Size/Amount", "Color");
                        Console.WriteLine(new string('-', 105));

                        // Read each line of the file and print as table row
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                        string[] userData = line.Split('|');
                        Console.WriteLine("{0,-35} {1,-15} {2,-25} {3,-20}", userData[0], userData[1], userData[2], userData[3]);
                        }

                    }
            
                    else if(filename=="pasutijumi.txt")
                    {

                        // Print the table header
                        Console.WriteLine("{0,-45} {1,-20} {2,-20} {3,-35} {4, -15} {5, -15} {6, -15}", "Item", "Client", "Phone number", "Address", "Date", "Company", "Status");
                        Console.WriteLine(new string('-', 210));

                        // Read each line of the file and print as table row
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] userData = line.Split('|');
                            Console.WriteLine("{0,-45} {1,-20} {2,-20} {3,-35} {4, -15} {5, -15} {6, -15}", userData[0], userData[1], userData[2], userData[3], userData[4], userData[5], userData[6]);
                        }
                    }
                }
            }
     
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}





