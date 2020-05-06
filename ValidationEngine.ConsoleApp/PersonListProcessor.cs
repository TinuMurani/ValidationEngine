using System;
using System.Collections.Generic;
using System.Text;
using ValidationEngine.Library;
using System.Linq;

namespace ValidationEngine.ConsoleApp
{
    internal static class PersonListProcessor
    {
        internal static void CheckPersonDetails(List<Person> people)
        {
            foreach (var person in people)
            {
                bool isValidFirstName = ValidationMethods.IsValid(person.Nume, UserDataTypes.StringType);
                bool isValidLastName = ValidationMethods.IsValid(person.Prenume, UserDataTypes.StringType);
                bool isValidCNP = ValidationMethods.IsValid(person.CNP, UserDataTypes.NumberStringType);
                bool isValidAge = ValidationMethods.IsValid(person.Varsta, UserDataTypes.AgeType);

                PrintPersonDetails(person, isValidFirstName, isValidLastName, isValidCNP, isValidAge);
            }
        }

        private static void PrintPersonDetails(Person person, bool isValidFirstName, bool isValidLastName, bool isValidCNP, bool isValidAge)
        {
            if (isValidFirstName && isValidLastName && isValidCNP && isValidAge)
            {
                Console.WriteLine($"Nume: { person.Nume }, Prenume: { person.Prenume }, CNP: { person.CNP }, Varsta: { person.Varsta }");
            }
            else
            {
                Console.WriteLine($"Numele este { (isValidFirstName ? person.Nume : "incorect") }, " +
                    $"Prenumele este { (isValidLastName ? person.Prenume : "incorect") }, " +
                    $"CNP-ul este { (isValidCNP ? person.CNP : "incorect") }, " +
                    $"Varsta este { (isValidAge ? person.Varsta.ToString() : "incorecta") }.", Console.ForegroundColor = ConsoleColor.Red);
                
                Console.ResetColor();
            }
        }
    }
}
