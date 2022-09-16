// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoops
{
    class Program
    {
        #region LukeWarm section
        static void Main(string[] args)
        {
            Thousands();
            Threes();
            Console.WriteLine(IsEqual(10, 20));
            EvenOrOdd(3);
            PosOrNeg(-20);
            VoteAge(20);
            TenRange();
            MultiTable();
            ageParse();
        }
        public static void Thousands() //Write a method that will print to the console all numbers 1000 through - 1000
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);

            }
        }
        public static void Threes() //Write a method that will print to the console numbers 3 through 999 by 3 each time
        {
            for (int t = 3; t <= 999; t += 3)
            {
                Console.WriteLine(t);
            }
        }

        public static bool IsEqual(int num1, int num2) //Write a method to accept two integers as parameterss and check whether they are equal or not
        {

            if (num1 == num2)
            {

                return true;
            }
            else
            {
               
                return false;
            }
        }

        public static void EvenOrOdd(int number)//Write a method to check whether a given number is even or odd
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"This is even");
            }
            else
            {
                Console.WriteLine($"This is odd");
            }
        }

        public static void PosOrNeg(int number) //Write a method to check whether a given number is positive or negative
        {
            if (number >= 0)
            {
                Console.WriteLine("This is Positive.");
            }
            else
            {
                Console.WriteLine("This is Negative.");
            }
        }

        public static bool VoteAge(int age) //Write a method to read the age of a candidate and determine whether they can vote.

        {
            if (age > 17)
            {
                Console.WriteLine("You are able to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("You are not able to vote");
                return false;
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        public static void ageParse()
        {
            int age;
            Console.WriteLine("Please enter your age.");
            age = int.Parse(Console.ReadLine());
            if (age > 17)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("You are still not old enough to vote");
            }
        }
        #endregion
        #region HeatingUp Section
        // Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void TenRange()
        {
            Console.WriteLine("Give me a number from -10 to 10");
            int range =Convert.ToInt32(Console.ReadLine());

            if (range < -10 || range > 10)
            {
                Console.WriteLine("Your number is not within the range.");
            }
            else if (range < 10 || range > -10)
            {
                Console.WriteLine("Your number is within the range.");
            }
           
        }
        #endregion
        public static void MultiTable()
        {
            //  Write a method to display the multiplication table(from 1 to 12) of a given integer
            Console.WriteLine("Give me a number to find the multiplication table from (1-12).");
            int given = Convert.ToInt32(Console.ReadLine());
            int multiplyInt;
            for (int i = 1; i <= 12; i++)
            {
                multiplyInt = given * i;
                Console.WriteLine(given + "*" + i + "=" + multiplyInt);
            }
        }



    }
}
