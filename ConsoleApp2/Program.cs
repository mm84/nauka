using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            for (; ; )
            {
                Przywitanie();
                Pytanieowiek();
                Ustawienia();
            }
        }

        //private static void NewMethod()
        //{
        //    int maxInt = int.MaxValue;
        //    int minInt = int.MinValue;
        //    long maxLong = long.MaxValue;
        //    long minLong = long.MinValue;

        //    Console.WriteLine("maxInt =" + maxInt);
        //    Console.WriteLine("minInt =" + minInt);
        //    Console.WriteLine("maxLong =" + maxLong);
        //    Console.WriteLine("minLong =" + minLong);
        //}

        /// <summary>
        /// Czyszczenie ustawień
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Pytanie o wiek
        /// </summary>
        private static void Pytanieowiek()
        {
            Console.WriteLine("Ile masz lat?");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Brawo, możesz wypić piwo");

            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadz poprawny wiek");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("możesz wypić mleko");

            }
        }
        /// <summary>
        /// Powitanie
        /// </summary>
        private static void Przywitanie()
        {
            Console.WriteLine("Wprowadź swoje imie");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}