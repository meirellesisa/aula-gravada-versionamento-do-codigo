namespace ProjetoAulas.RecursosDoDotNet
{
    public class TrabalhandoComDatas
    {
        public static void AulaDateTime()
        {
            var date1 = new DateTime(2026,07,01,19,22,23);
            Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

            var date2 = DateTime.Parse("2026/07/01 19:22:23");
            Console.WriteLine(date2);

            var date3 = DateTime.Now;
            Console.WriteLine(date3);

            var date4 = DateTime.Today;
            Console.WriteLine(date4);

            var dateoffset1 = new DateTimeOffset(
                DateTime.Now, 
                new TimeSpan(-3, 0, 0));

            Console.WriteLine(dateoffset1.LocalDateTime);
            Console.WriteLine(dateoffset1.UtcDateTime);
        }

        public static void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;

            var date2 = DateTime.Parse("2026-01-01");

            var diff = date1 - date2;

            diff = date1.Subtract(date2);

            Console.WriteLine((int)diff.TotalDays);
            Console.WriteLine((int)diff.TotalHours);
        }

        public static void AulaAdicionandoDiasMesAnos()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yy HH:mm:ss"));
            Console.WriteLine(date1.AddYears(2).ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public static void AulaAdicionandoHoraMinutoSegundo()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.ToString("HH:mm:ss"));

            Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));

            Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));

            Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));

        }

        public static void AulaDiaDaSemana()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.DayOfWeek);

            var date2 = date1.AddDays(3);
            Console.WriteLine(date2.DayOfWeek);
        }

        public static void AulaDateOnly()
        {
            var somenteData1 = new DateOnly(2026, 07, 06);
            Console.WriteLine(somenteData1.ToString("dd-MM-yyyy"));

            var somenteData2 = DateOnly.Parse("2026/07/01");
            Console.WriteLine(somenteData2);

            Console.WriteLine(somenteData2.AddDays(5));
            Console.WriteLine(somenteData2.AddMonths(2));
            Console.WriteLine(somenteData2.AddYears(1));



        }

        public static void AulaTimeOnly()
        {
            //var somenteHora = TimeOnly.Parse("23:01:23");
            var somenteHora = new TimeOnly(12, 23, 25,0);


            Console.WriteLine(somenteHora.ToString("HH:mm:ss"));

            Console.WriteLine(somenteHora.AddHours(2).ToString("HH:mm:ss"));
            Console.WriteLine(somenteHora.AddMinutes(20).ToString("HH:mm:ss"));

        }

    }
}
