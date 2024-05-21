// using System;

// namespace Testing3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Clear();
// var data = new DateTime(1986, 10, 29, 9, 15, 0);
// DateTime? data = null;
// var data = DateTime.Now;

// Console.WriteLine(data.Year);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Day);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.DayOfWeek);
// Console.WriteLine(data.DayOfYear);
// Console.WriteLine(data);
// var formatted = String.Format("{0: dd/MM/yyyy hh:mm:ss ff zzz}", data);

// *Padrões
// var formatted = String.Format("{0:d}", data);
// var formatted = String.Format("{0:D}", data);
// var formatted = String.Format("{0:f}", data);
// var formatted = String.Format("{0:r}", data);
// var formatted = String.Format("{0:s}", data); 
// var formatted = String.Format("{0:u}", data);

// *Adicionando datas
// Console.WriteLine(data);
// Console.WriteLine(data.AddDays(12));
// Console.WriteLine(data.AddDays(-12));
// Console.WriteLine(data.AddMonths(1));
// Console.WriteLine(data.AddYears(1));
// Console.WriteLine(data.AddHours(1));

// *Comparação de datas

//             if (data.Date == DateTime.Now.Date) // para todos os tipos de comparação
//                 Console.WriteLine("É igual");

//         }
//     }
// }

