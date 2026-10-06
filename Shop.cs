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
            



        }
    }
}
