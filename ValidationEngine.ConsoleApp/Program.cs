using System;
using System.Collections.Generic;
using ValidationEngine.Library;

namespace ValidationEngine.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Nume = "Murani", Prenume = "Tinu", CNP = "1840803055084", Varsta = 35 },
                new Person { Nume = "Banner", Prenume = "Bruce", CNP = "1741201055162", Varsta = 45 },
                new Person { Nume = "Clark", Prenume = "Kent", CNP = "1811108055358", Varsta = 38 },
                new Person { Nume = "Parker", Prenume = "Peter", CNP = "5030108055218", Varsta = 17 },
                new Person { Nume = "Sue", Prenume = "Storm", CNP = "2960702055011", Varsta = 24 },
            };

            PersonListProcessor.CheckPersonDetails(people);

            Console.ReadLine();
        }
    }
}
