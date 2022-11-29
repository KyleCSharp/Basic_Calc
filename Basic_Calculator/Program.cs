using System;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to my basic calculator");

            Console.WriteLine("please give me an operator Example = +, -, *, /, %, and hit ENTER");
            Console.WriteLine("Please note % in this situation stands for Modulus.. Returns the division remainder EX x % y");
            var userInput = Console.ReadLine();

            Console.WriteLine("Now two numbers");
            Console.WriteLine("please type the first and hit ENTER");
            var UserNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now the 2nd");
            var UserNum2 = int.Parse(Console.ReadLine());

            if (userInput == "+")
            {
                Console.WriteLine($"Result : {UserNum1 + UserNum2}");
            }
            if (userInput == "-")
            {
                Console.WriteLine($"Result : {UserNum1 - UserNum2}");
            }
            if (userInput == "*")
            {
                Console.WriteLine($"Result : {UserNum1 * UserNum2}");
            }
            if (userInput == "/")
            {
                Console.WriteLine($"Result : {UserNum1 / UserNum2}");
            }








        }
    }
}
