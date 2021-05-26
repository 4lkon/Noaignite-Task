using System;
using System.Globalization;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "dd.MM.yyyy";

            //first date
            Console.WriteLine("Podaj datę początkową o podanym formacie - (DD.MM.RRRR):");
            DateTime time1 = DateTime.MinValue;
            bool isValidateTime = false;
            while (isValidateTime != true)
                try
                {
                    DateTime x1 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    isValidateTime = true;
                    time1 = x1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format daty. Proszę wprowadzić poprawną datę.");

                }

            //second date
            DateTime time2 = DateTime.MinValue;
            Console.WriteLine("Podaj datę końcową o podanym formacie - (DD.MM.RRRR):");
            while (isValidateTime != false)
            {
                try
                {
                    DateTime x2 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    isValidateTime = false;
                    time2 = x2;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format daty. Proszę wprowadzić poprawną datę.");

                }
            }

            //output
            Console.WriteLine(Console.Title + ' ' + time1.ToString("dd/MM/yyyy") + ' ' + (time2.ToString("dd/MM/yyyy")));
            Console.WriteLine(time1.ToString("dd") + '-' + time2.ToString("dd/MM/yyyy"));
            Console.WriteLine(time1.ToString("dd/MM") + '-' + time2.ToString("dd/MM/yyyy"));
            Console.WriteLine(time1.ToString("dd/MM/yyyy") + '-' + time2.ToString("dd/MM/yyyy"));
            Console.WriteLine("\nNaciśnij dowolny klawisz aby zamknąć...");
            Console.ReadKey();
        }
    }
    }






