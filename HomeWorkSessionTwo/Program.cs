using System;

public class Program
{
    
    private static void Main(string[] args)
    {
       // Console.WriteLine("Exercise 1");
        //Exercise1();

        Console.WriteLine("Exercise 2");
        Exercise2();

        Console.WriteLine("Exercise 3");
        Exercise3();

        // Console.WriteLine("Exercise 4");
        //Exercise4();

        // Console.WriteLine("Exercise 5");
        // Exercise5();
    }

    //
    // Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not.
    // Testdata: 16324 is divisible by both 7 and 11
    private static void Exercise1()
    {
        Console.WriteLine("Enter a number:");
        int keyboardNumber = Convert.ToInt32(Console.ReadLine());
        if (keyboardNumber % 7 == 0 && keyboardNumber % 11 == 0)
        {
            Console.WriteLine("The number you have entered is divisible by both 7 and 11!");
        }
        else
        {
            Console.WriteLine("The number you have entered is not divisible by both 7 and 11");
        }
    }

    //
    //Check whether a given year is leap year or not.
    //Testdata: 1997 and 2012
    private static void Exercise2()
    {
        Console.WriteLine("Enter a number:");
        int year = Convert.ToInt32(Console.ReadLine());
        if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine("The year you have entered is a leap year, congrats!");
        }
        else
        {
            Console.WriteLine("The year you have entered is not a leap year :(");
        }

    }

    //
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 47th prime number?
    //
    private static void Exercise3()
    {



    }





























}

