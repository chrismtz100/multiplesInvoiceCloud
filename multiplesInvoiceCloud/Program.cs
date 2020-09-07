using System;
using System.Linq;

namespace multiplesInvoiceCloud
{
    public class Program
    {
        public static void MultipleCheck()
        {
            //User input of array
            Console.WriteLine("How many numbers would you like to test?");

            //create new array of size X (Ex. 100)
            int maxNum;
            while (!int.TryParse(Console.ReadLine(), out maxNum) || maxNum < 0) //Checks for just positive numbers.
            {
                Console.WriteLine("Invalid input. Must be a positive integer.");
            }
            

            //create new array and insert numbers from 1 - maxNum
            int[] num = Enumerable.Range(1, maxNum).ToArray();

            foreach (int i in num) //o(n*1) = o(n)
            {
                bool flagThree = false;
                bool flagFive = false;

                if ((i % 3) == 0) flagThree = true; //is this a multiple of 3
                if ((i % 5) == 0) flagFive = true; //is this a multiple of 5

                if (flagThree && !flagFive) Console.WriteLine("Invoice"); //n(1)
                else if (!flagThree && flagFive) Console.WriteLine("Cloud");
                else if (flagThree && flagFive) Console.WriteLine("InvoiceCloud");
                else Console.WriteLine(i);
            }

        }

        public static void Main(string[] args)
        {
            MultipleCheck();
            Console.WriteLine("Execution Complete...");
        }
    }
}
