using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();

        }

        static void Welcome()
        {
            Console.Clear();

            Console.WriteLine("Welcome to our Calculator!");
            Console.WriteLine("Please, choose the operation");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Welcome(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Sum");
            Console.WriteLine("================================");

            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("You want to sum " + v1 + " + " + v2);
            Console.WriteLine($"The result is {resultado}"); // interpolação de strings
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            Welcome();

        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction");
            Console.WriteLine("================================");


            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"You want to subtract {v1} and {v2}");
            Console.WriteLine($"The result is {v1 - v2}");
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            Welcome();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Division");
            Console.WriteLine("================================");


            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"You want to divide {v1} and {v2}");
            Console.WriteLine($"The result is {v1 / v2}");
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            Welcome();

        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiplication");
            Console.WriteLine("================================");


            Console.WriteLine("First value:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"You want to multiply {v1} and {v2}");
            Console.WriteLine($"The result is {v1 * v2}");
            Console.WriteLine("Press Enter");
            Console.ReadKey();
            Welcome();
        }


    }


}