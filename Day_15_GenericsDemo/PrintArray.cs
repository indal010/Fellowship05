using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_GenericsDemo
{
    class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------");
        }
    }
    
    class Program1
    {
        static void Main()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("----------------------------");
            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
            Console.ReadKey();
        }
    }
   
}
