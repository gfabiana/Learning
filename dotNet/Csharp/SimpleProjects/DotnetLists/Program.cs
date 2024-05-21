using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new int[5]; // array com zeros
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };

            // meuArray[0] = 12;

            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);
            // Console.WriteLine(meuArray[5]); // Erro: sexta posição

            // for (var index = 0; index < meuArray.Length; index++)
            // {
            //     Console.WriteLine(meuArray[index]);
            // }

            // foreach (var index in meuArray) // sem necessidade de colocar todos os parâmetros do for
            // {
            //     Console.WriteLine(index);
            // }

            // *Modificando valores
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];
            Console.WriteLine(primeiro[0]);
            Console.WriteLine(segundo[0]);
            primeiro[0] = 23;
            Console.WriteLine(primeiro[0]);
            Console.WriteLine(segundo[0]);


        }
    }
};