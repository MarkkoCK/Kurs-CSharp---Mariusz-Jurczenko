using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // Tworzenie instancji klasy obiektu dzienniczka
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenê z zakresu 1 do 10");

                float rating;
                bool resoult = float.TryParse(Console.ReadLine(), out rating); //TryParse - parsowanie liczby na float wraz z zabezpieczeniem przed wprowadzeniem cyfry zamiast liczby
                                
                if (rating == 11)
                {
                    break;
                }

                if (resoult)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pdana liczba jest niepoprawna, liczba jest z poza zakresu od 0 do 10");
                        Console.ResetColor();
                    }
                }
                
            }

            Console.WriteLine("Srednia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwy¿sza ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najni¿sza ocena to: " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
