using System;
using System.Diagnostics;
using System.Threading;

namespace Timer
{
    class Program
    {
        static int option;
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Please, select one of these options:");
            Console.WriteLine("1: Stopwatch");
            Console.WriteLine("2: Countdown");
            Console.WriteLine("0: Exit");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1:
                case 2:
                    Counter(); break;
                default:
                    Menu(); break;
            }


        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!");
            Thread.Sleep(2000);

            switch (option)
            {
                case 1: Stopwatch(time); break;
                case 2: Countdown(time); break;
                default: Menu(); break;
            }
        }

        static void Counter()
        {
            Console.Clear();
            Console.WriteLine("S: Second ---> 1s = 1 second");
            Console.WriteLine("M: Minute ---> 1m = 1 minute");
            Console.WriteLine("0 ---> Exit");
            Console.WriteLine("How much time do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);


        }

        static void Stopwatch(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("End");
            Thread.Sleep(2000);
            Menu();
        }

        static void Countdown(int time)
        {
            int endTime = 0;
            time += 1;

            while (endTime != time)
            {
                Console.Clear();
                time--;
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("End");
            Thread.Sleep(2000);
            Menu();

        }
    }
}
