using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void print1000s()
        {
            Console.WriteLine("numbers 1000 through -1000");
            for (int a = 1000; a <= -1000; a++)
            {
                Console.WriteLine(a);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void print3999()
        {
            Console.WriteLine("numbers 3 through 999 by 3");
            for (int b = 3; b <= 999; b += 3)
            { Console.WriteLine(b); }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal!");
            }
            else
            {
                Console.WriteLine("Numbers are not equal.");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void Odd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is even");
            }
            else
            {
                Console.WriteLine($"{num1} is odd");

            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void Positive(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine($"{num1} is positive.");
            }
            else if (num1 < 0)
            {
                Console.WriteLine($"{num1} is negative.");
            }
            else
            {
                Console.WriteLine($"{num1} is not positive or negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void vote()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Enter your age");
                userAge = int.TryParse(Console.ReadLine(), out result);


            }while (!userAge);
            if (result < 18)
            {
                Console.WriteLine("Sorry, you are too young");
            } 
            else 
            { 
                Console.WriteLine("Hey you can vote, thats great!"); 
            
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10


        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            print1000s();
            print3999();
            EqualOrNot(5,9);
            Odd(9);
            Positive(8);
            vote();
        }
    }
}
