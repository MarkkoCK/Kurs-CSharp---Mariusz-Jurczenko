using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kontynuacja dzienniczka od odcinka 12
//https://www.youtube.com/watch?v=ddSxWqb44IA&index=12&list=PL9T2pvCNFjSCEPw4Dt3-z8WyoYoxBvEwY
namespace StudentDiary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // Tworzenie instancji klasy obiektu dzienniczka
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            DiaryStatistics stats = diary.ComputeStats();

            Console.WriteLine("Średnia wartość: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            Diary diary2 = new Diary();
            diary2.AddRating(65);
            diary2.AddRating(3.7f);
            diary2.AddRating(6.1f);

            stats = diary2.ComputeStats();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Dzienniczek nr 2");
            Console.WriteLine("Średnia wartość ocen dzienniczek nr 2 : " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena dzienniczek nr 2 : " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena dzienniczek nr 2 : " + stats.MinGrade);

            Console.ReadKey();
        }
    }
}
