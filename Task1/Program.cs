using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your first name?");
            string FirstName;
            string LastName;
            FirstName = Console.ReadLine();
            Console.WriteLine("What's your second name?");
            LastName = Console.ReadLine();
            Console.WriteLine("When were you born?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine($"Hello, {FirstName} {LastName}, you are {Age} years old.");
        }
    }
}
