using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname; // Imię
        string lastname; // Nazwisko
        string adress; // Adres
        int age; // Wiek
        string gender; //płeć

        public Person()
        {
            id = 1;
            firstname = "Marcin0";
            lastname = "Kowalski";
            age = 14;
        }

        public Person(int id, string firstname, string lastname, string adress, int age, string gender)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            adress = "Kielce";
            age = 18;
        }

        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;
        }
    }
}
