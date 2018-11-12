using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary2
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        List<float> ratings; //Lista ocen ang. ratings = lista

        // Zachowania (metody)

        public void AddRating(float rating) //Dodanie ocen do listy ratings - metoda
        {
            ratings.Add(rating); //dodanie oceny do listy ocen
        }

        internal DiaryStatistics ComputeStats()
        {
            DiaryStatistics stats = new DiaryStatistics();
            float sum = 0f;
            foreach (var rating in ratings)
            {
               sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();

            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}
