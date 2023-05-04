using System;
using System.IO;
using System.Linq;

class DeleteData
{
    public static void DeleteLine(string filename, int lineNumber)
    {
        string[] lines = File.ReadAllLines(filename);

        if (lineNumber < 1 || lineNumber > lines.Length)
        {
            Console.WriteLine("Invalid line number. Please try again.");
            return;
        }

        lines = lines.Where((line, index) => index != lineNumber - 1).ToArray();
        File.WriteAllLines(filename, lines);

        Console.WriteLine($"Line {lineNumber} deleted from file.");
    }

    public static void DeleteLines(string filename, string lineNumbers)
    {
        string[] lines = File.ReadAllLines(filename);

        int[] numbers = lineNumbers.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
        if (numbers.Any(n => n < 1 || n > lines.Length))
        {
            Console.WriteLine("Invalid line numbers. Please try again.");
            return;
        }

        lines = lines.Where((line, index) => !numbers.Contains(index + 1)).ToArray();
        File.WriteAllLines(filename, lines);

        Console.WriteLine($"Lines {lineNumbers} deleted from file.");
    }

    public static void DeleteAllLines(string filename)
    {
        File.WriteAllText(filename, "");
        Console.WriteLine($"All lines deleted from file {filename}.");
    }

    public static void ShowLines(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {lines[i]}");
        }
    }
    public static void DataDeliting(string filename)
    {
        DeleteData.ShowLines(filename);
        Console.WriteLine("Press 1 if you want to delete one line. \nPress 2 if you want to delete multiple lines. \nPress 3 if you want to delete all lines.");
        int deleteChoice = 0;
        bool validChoice = false;
        while (!validChoice)
        {
            if (int.TryParse(Console.ReadLine(), out deleteChoice) && deleteChoice >= 1 && deleteChoice <= 3)
            {
                validChoice = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1, 2 or 3.");
            }
        }

        if (deleteChoice == 1)
        {
            Console.Write("Enter line number to delete: ");
            int deleteLine = Convert.ToInt32(Console.ReadLine());
            DeleteData.DeleteLine(filename, deleteLine);
        }
        else if (deleteChoice == 2)
        {
            Console.WriteLine("Choose lines to delete (comma-separated):");
            string deleteLines = Console.ReadLine();
            DeleteData.DeleteLines(filename, deleteLines);
        }
        else if (deleteChoice == 3)
        {
            DeleteData.DeleteAllLines(filename);
        }
    }
}