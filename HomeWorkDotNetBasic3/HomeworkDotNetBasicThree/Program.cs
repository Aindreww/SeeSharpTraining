using HomeworkDotNetBasicThree;
using System;



    class Program
    {
        static void Main(string[] args)
        {
            Linq processor = new Linq();
            processor.ProcessData();

            Console.WriteLine("Queries completed and JSON file written successfully.");
        }
    }
