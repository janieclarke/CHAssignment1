using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomGame.Run()

            Console.Write("Please enter a number between 0 and 5: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User Input: " + userInput);

            Random random = new Random();
            int randomNumber = random.Next(0, 6);

            Console.WriteLine("Computer Input: " + randomNumber);

            if (userInput > 5)
            {
                Console.WriteLine("User Input is invalid.");
            }
            else if (userInput == randomNumber)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("McPhail");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
