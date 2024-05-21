using System;
using System.Globalization;

namespace WorkingWithDates

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // *CultureInfo
            // var pt = new CultureInfo("pt-BR");
            // var es = new CultureInfo("es-ES");
            // var ch = new CultureInfo("zh-CN");
            // var de = new CultureInfo("de-DE");
            // var atual = CultureInfo.CurrentCulture;

            // Console.WriteLine(DateTime.Now.ToString("D", pt));
            // Console.WriteLine(DateTime.Now.ToString("D", es));
            // Console.WriteLine(DateTime.Now.ToString("D", ch));
            // Console.WriteLine(DateTime.Now.ToString("D", de));
            // Console.WriteLine(DateTime.Now.ToString("D", atual));

            // *Timezone
            // var utcDate = DateTime.UtcNow; //Hora universal: ideal aplicações globalizadas e depois aplicar CultureInfo

            // Console.WriteLine(utcDate);
            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            // *Listar todos os timezones
            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //     Console.WriteLine("______________________");
            // }

            // *Timespan: realiza cálculos de tempo
            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundo = new TimeSpan(15, 12, 55, 8);

            // Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            // *Mais funções úteis
            Console.WriteLine(DateTime.DaysInMonth(2024, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // Horário de verão: bool, baseado na cultura da máquina


            static bool IsWeekend(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
        }
    }
}