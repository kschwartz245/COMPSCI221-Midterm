using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPSCI221_Midterm
{
    internal class Shop
    {
        static void PrintMenu()
        {
            Console.WriteLine("Select an Option:\n1. Exit Program\n2. Add Item\n3. Remove Item\n4. Save Data\n5. Load Data");
        }

        static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path);
            }

            int count = 0;
            using StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }

            return count;
        }

        static string ReadHeaderFromFile(string path)
        {
            using StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            return line;
        }

        static Item[] ReadItemsFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Error finding file");
            }

            Item[] items = new Item[GetLineCount(path) - 1];
            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();

            for (int i = 0; i < items.Length; i++)
            {
                string line = reader.ReadLine();
                string[] col = line.Split(',');

                //Parse data here for item file

                items[i] = new Item();
            }
            return items;
        }

        //need readfile and writefile for savedata
        //Gold amount and array of shop parsed in and out of csv file

        static void Main()
        {
            //need initial gold
            //string for path of items
            //string for path of savedata

            //need list of items imported to refer to i.e. ReadItemsFromFile()

            //Loop needed that runs until specific input from console entered
            //need a Console.WriteLine listing for options for user
            //switch or if statements for options
            //


            bool exit = false;
            int choice;
            string input;
            PrintMenu();
            while (!exit)
            {
                input = Console.ReadLine();
                bool isValid = int.TryParse(input, out choice);
                if (!isValid)
                {
                    Console.WriteLine("Input not valid! Numbers Only");
                }
                else
                {
                    Console.Clear();
                    PrintMenu();
                    switch (choice)
                    {
                        default:
                            Console.WriteLine("\nSelect an option from the list");
                            break;
                        case (1):// Exit Program
                            exit = true;
                            break;
                        case (2):// Add Item
                            break;
                        case (3):// Remove Item
                            break;
                        case(4):// Save Data
                            break;
                        case(5):// Load Data
                            break;
                    }
                }

            }
        }
    }
}
