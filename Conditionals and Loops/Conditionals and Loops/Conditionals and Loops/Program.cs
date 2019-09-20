using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_and_Loops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Press a number between one and three (inclusive)");

            // Get user input (true is to disable echo of the pressed key)
            ConsoleKeyInfo UserInput = Console.ReadKey(true);

            // Check if the pressed key is a digit
            if (char.IsDigit(UserInput.KeyChar))
            {
                // Convert it to an integer
                num = int.Parse(UserInput.KeyChar.ToString());
            }
            else
            {
                num = 0;
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("You pressed \"one\"");
                    break;

                case 2:
                    Console.WriteLine("You pressed \"two\"");
                    break;

                case 3:
                    Console.WriteLine("You pressed \"Three\"");
                    break;

                default:
                    Console.WriteLine("That wasn't a number between one and three (inclusive), dumb dumb");
                    break;
            }

            // Debugging trick to prevent instantly closing the console upon program completion
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }
    }
}