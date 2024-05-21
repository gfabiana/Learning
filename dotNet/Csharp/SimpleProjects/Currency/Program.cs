using System;
using System.Globalization;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 14254.26m; // Mesmo o decimal sendo menos eficiente, recomenda-se no uso de moedas, por ser mais preciso

            // Console.WriteLine(valor); // cultura da máquina
            // Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("ch-CH")));
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("en-US"))); // deve ser de "general"
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("ch-CH")));
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
            // Console.WriteLine("_______________________________________");
            // Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

            // *Arredondamentos
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor)); // arredonda pra cima
            Console.WriteLine(Math.Floor(valor)); // arredonda pra baixo

        }
    }
}