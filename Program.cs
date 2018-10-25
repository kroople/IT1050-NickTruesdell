using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassW6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i;

            i = 30;
            while (i >= 10) 
            {
                Console.WriteLine(i);
                i = i - 2;
            }
            */

            /*int numValue;
            int exponentValue;
            int resultValue;
            int i;

            Console.WriteLine("Enter the number value:");
            numValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, enter an exponent:");
            exponentValue = int.Parse(Console.ReadLine());

            */

            // If statements do the process once if something is true, while statements continue to do the process while something is true.

            
            int speedLimit;
            int speed;
            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("Slow Down");
            }
            else
            {
                Console.WriteLine("Safe Driving!");
            }
            
            
            bool isTrue;

            isTrue=true;

            if (isTrue=true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
            console.writeline("It is false!");
            }
            
            //F to C converter

            double celsius;
            Console.Write("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is " + celsius);
            Console.ReadLine();


            
            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);
                
                i = i + 1;
            }

            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);

                i = i - 1;
            }

            for (i = 10; i <= 20; i = i + 10)
            {
                Console.WriteLine(i);
            }





            /* i = 1;
            resultValue = numValue;

            while (i < exponentValue)
            {
                resultValue = resultValue * exponentValue;
                i = i + 1;
            }

            Console.WriteLine("The result is = {0}", resultValue);
            */


        }
    }
}