using System;

namespace Day21_CSVHelperAndJson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("# Read data from CSV & Write data in CSV");
            //CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();

            Console.ReadKey();
        }
    }
}
