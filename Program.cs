using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mike's C# If Test.
namespace ConsAppUsingIfCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            int Val1 = 1;
            int Val2 = 0;

            System.Console.WriteLine("Getting ready to do the If Statement...");

            if(Val1 == Val2)
            {
                System.Console.Write("If condition was true.");
            }
            System.Console.WriteLine("Done with the If Statement Mike.");
            System.Console.ReadKey(); //pauses the programme until anykey is pressed.
        }
    }
}
// Here the condition is false, because Val1 doesn't equal Val2. 