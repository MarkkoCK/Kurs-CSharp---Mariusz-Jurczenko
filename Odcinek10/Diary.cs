using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Diary
    {
        public Diary() // ctor + tab tab - automatycznie utworz definicje tworzenia konstruktora obiektu
        {
            ratings = new List<float>();
        }
        // Stan (zmienne - pola)
        List<float> ratings; //Lista ocen ang. ratings = lista

        // Zachowania (metody)
        /// <summary>
        /// Dodawanie oceny do listy ocen.
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(float rating) //Dodanie ocen do listy ratings - metoda
        {
            ratings.Add(rating); //dodanie oceny do listy ocen
        }

        // Metoda wyliczająca ssrednia ocen
        /// <summary>
        /// Oblicza średnią z naszych ocen.
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0; // deklaracja zmiennych suma oraz średnia typu float

            foreach (var rating in ratings)
            {
                //sum = sum + rating;
                sum += rating; //skrocony zapis dodawania ocen do sumy
            }

            avg = sum / ratings.Count(); // Obliczanie średniej ocen - Count() z Linq

            return avg; //Zwracenie średniej oceny
        }

        /// <summary>
        /// Pobiera najwyższa ocenę.
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating() // Pobierz maksymalnia ovcenę
        {
            return ratings.Max(); // Zwraca maksymalną wartość z listy - Max() z Linq
        }

        /// <summary>
        /// Pobiera najniższą ocenę.
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating() // Pobierz minimalną ovcenę
        {
            return ratings.Min(); //Zwraca najmniejsza liczbę z lisrty ratings - Min() z Linq
        }
        
    }
}
