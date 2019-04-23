using System;

namespace lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            while (true)
            {

                //comment
                Console.WriteLine("Enter Length:");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("Perimeter: " + 2 * length + 2 * width);

                Console.WriteLine("Enter Height:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Volume: " + length * width * height);

                Console.WriteLine("Continue? (y/n)");
                string userResponse = Console.ReadLine();
                string userResponseLower = userResponse.ToLower();

                if (userResponseLower == "yes" || userResponseLower == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Too bad. BYE!");
                    break;
                }
            }
        }
    }
}
