using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            /*
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(names[1]);
            Console.WriteLine(names[4]);
            

            // 2.
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine((i + 1) + " " +months[i]);
            }
            

            // 3.------------------------------------------------------------------------------
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons) //                for each statement with array!
            {
                Console.WriteLine(season);
            }
            */

            //4.-------------------------------------------------------------------------------

            int[] randomNum = new int[1000]; // random number generator

            Random random = new Random();
            

            for (int a = 0; a < randomNum.Length; a++)
            {
                randomNum[a] = random.Next(0, 1000); //tells it between 1 and 1000
            }
            
            foreach (int i in randomNum) // this prints the numbers
            {
                Console.WriteLine(i.ToString());
            }

        }

    }
}
