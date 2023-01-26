using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MeasuringPerfWithStopwatch
{
    public class Program
    {
        static readonly Stopwatch timer = new Stopwatch();
        static Random rnd = new Random();
        public static async Task Main(string[] args)
        {
            timer.Start();

            Console.WriteLine("Program Start - " + timer.Elapsed.ToString());
            Console.WriteLine("********************************\n");

            await PerformValidationsAsync();
            Console.WriteLine("Validation Performed - " + timer.Elapsed.ToString());
            //Optional reporting metrics
            //Console.WriteLine($"ElapsedMilliseconds  : {timer.ElapsedMilliseconds}");
            //Console.WriteLine($"ElapsedTicks  : {timer.ElapsedTicks} \n");

            await GetDataFromAPIAsync();
            Console.WriteLine("Got Data from API - " + timer.Elapsed.ToString());
            

            await SaveToDBAsync();
            Console.WriteLine("Saved to DB - " + timer.Elapsed.ToString());
          
            Console.WriteLine("\nProgram End");
            Console.WriteLine("***********");

            timer.Stop();
        }

        private static async Task PerformValidationsAsync()
        {
            
            await Task.Delay(rnd.Next(3000));
        }

        private static async Task GetDataFromAPIAsync()
        {
            await Task.Delay(rnd.Next(3000));
        }

        private static async Task SaveToDBAsync()
        {
            await Task.Delay(4000);
        }
    }
}