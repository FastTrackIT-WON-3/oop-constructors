using System;

namespace OopConstructors
{
    public class Person
    {
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = new DateTime(1950, 1, 1);
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}, date of birth: {DateOfBirth}");
        }
    }
}
