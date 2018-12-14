using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSquaresOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            //Intro to what the program does
            Console.WriteLine("Please enter a natural number and press Enter! The program will calculate the sum of the squares of all natural numbers from one to your number.");
            //User input
            long limit = Convert.ToInt32(Console.ReadLine());
            //Further instructions
            Console.WriteLine("Please enter how many times you want to repeat the calculation (in order to get an accurate average processing time).");
            //User input
            int repeat = Convert.ToInt32(Console.ReadLine());

            List<long> times = new List<long>();
            long sum = 0;
            //Perform the operation repeat times
            for (int j = 0; j < repeat; j++)
            {
                sum = 0;
                //Start stopwatch
                var watch = System.Diagnostics.Stopwatch.StartNew();
                //Compute the sum
                for (long i = 1; i < limit + 1; i++)
                {
                    sum += i * i;
                }
                //Stop the watch
                watch.Stop();
                times.Add(watch.ElapsedMilliseconds);
            }
            //Write results with average execution time
            Console.WriteLine("The result is: " + sum + ", and it took " + times.Average() + " milliseconds to calculate.");

            goto Start;
        }
    }
}
