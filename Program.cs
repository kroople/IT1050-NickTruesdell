using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Midterm
{
    class Program
    {
        static void Main()
        {
            // 1050 Midterm - Nicholas Truesdell

            // 1. -------------------------------------------------------------------
            /*
            
            bool keeplooping;
            keeplooping = true;

            while (true)
            {
                Console.WriteLine("This will print forever!");
            }

           
            // 2. -------------------------------------------------------------------

            int product = 2;
            while (product < 128)
            {
                product = 2 * product;
                Console.WriteLine($"[{product}]");
            }
            

            // 3. --------------------------------------------------------------------

            for (int counter = 49; counter>=1; --counter)
            {
                Console.Write($" {counter},");
                
            }
            
            
            // 4. --------------------------------------------------------------------

            
            int product = -1;
            while (product < 21)
            {
                product = product+2;
                Console.Write($"   {product}   ");
            }

            
            // 5. ---------------------------------------------------------------------

            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            // The difference between do-while and while is the order of execution. 
            // In do-while, it tests the loop continuation condition after executing the loops body. The body will always execute once.
            // In while, it tests the loop continuation condition at the beginning of the loop, before executing the loop's body. If condition is false, body of the loop never executes.
            */

            //6. -----------------------------------------------------------------------
            bool icyRain = true;
            bool tornadoWarning = true;


            if ((icyRain) || (tornadoWarning))
            {
                Console.WriteLine("Let's go Outside!");
            }
            










        }
    }
}
