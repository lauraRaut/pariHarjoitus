using System;
using System.Collections.Generic;
using System.Linq;

namespace week2excPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();

            Person jukka = new Person("Jukka", "Turtiainen", "jukka.turt@gmail.com", new DateTime(2006, 1, 16));
            pList.Add(jukka);

            Person Maija = new Person("Maija", "Mehiläinen", "Maija.Meh@gmail.com", new DateTime(1989, 10, 04));
            pList.Add(Maija);

            Person Juulia = new Person("Juulia", "Soponen", "jullesoppa@hotmail.com", new DateTime(1966, 12, 12));
            pList.Add(Juulia);

            Person Sassi = new Person("Sassi", "Huuhka", "hussa@jippii.fi", new DateTime(1932, 03, 28));
            pList.Add(Sassi);

            Person Tintti = new Person("Tintti", "Koski", "koskentintti@suomi24.fi", new DateTime(2012, 07, 07));
            pList.Add(Tintti);

            DateTime nyt = DateTime.Now;
            Console.WriteLine(nyt);



            /*IEnumerable<Person> result = pList.Find(per => per.perAge > 30;*/

            foreach(Person per in result)
            {
                Console.WriteLine(per);
            }

            result = from per in pList
                     where per.Birthday == nyt.AddYears(-30)
                     select per;

            //Console.WriteLine(pList[1].FirstName);

           foreach (Person boo in pList)
            {
                Console.WriteLine(boo.FirstName + " " + boo.LastName + " " + boo.Email + " " + boo.Birthday);
            }
         }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime Birthday { get; set; }

            public Person(string aFirstName, string aLastName, string aEmail, DateTime aBirthday)
            {
                this.FirstName = aFirstName;
                this.LastName = aLastName;
                this.Email = aEmail;
                this.Birthday = aBirthday;
            }

            public Person(string aFirstName, string aLastName, string aEmail)
            {
                this.FirstName = aFirstName;
                this.LastName = aLastName;
                this.Email = aEmail;
            }

            public Person(string aFirstName, string aLastName, DateTime aBirthday)
            {
                this.FirstName = aFirstName;
                this.LastName = aLastName;
                this.Birthday = aBirthday;

            }
            // Luo metodi, joka palauttaa käyttäjän iän
            // luo ohjelma, joka luo kätevästi viisi Person-oliota ja lisää ne collectioniin
            // luo tapa palauttaa henkilöt, jotka ovat vanhempia kuin collectionin henkilöt keskiarvolta
        }
    }
}
