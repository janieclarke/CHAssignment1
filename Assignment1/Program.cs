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
            /*Console.WriteLine("Hello World");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();*/

            Console.Write("Please enter a number between 0 and 5: ");

            
            int intUserInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("User Input: " + intUserInput);


            Random rnd = new Random();
            int intCompInput = rnd.Next(0, 6);

            Console.WriteLine("Computer Input: " + intCompInput);

            if (intUserInput >5)
            {
                Console.WriteLine("User Input is invalid.");
            }
            else 
                if (intUserInput == intCompInput )
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
