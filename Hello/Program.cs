using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();

            for (; ; )
            {
                Przywitanie();
                Wiek();
                Ustawienia();
            }
            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj " + item);
            //}
        }

        /// <summary>
        /// Maksymalna wielkoœæ typów int i long
        /// </summary>
        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = "+ maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }


        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zale¿ny od wieku
        /// </summary>
        private static void Wiek()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo. Jesteœ pe³noletni mo¿esz wypiæ browara");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadzi³eœ niepoprawny wiek!");
            }
            else
            {
                Console.WriteLine("Mo¿emy ci zaoferowaæ mleko");
            }
        }
        
        /// <summary>
        /// Wypisujemu powitanie uzytkownika
        /// </summary>
        private static void Przywitanie()
        {
            Console.Write("Wpisz swoje imiê: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
