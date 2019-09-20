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
            int num = 3;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;
            }

            // Debugging tool to prevent instantly closing the console upon program completion
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }
    }
}