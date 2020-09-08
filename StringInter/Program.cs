using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string SecondName;
            Console.WriteLine("What's your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What's your second name?");
            SecondName = Console.ReadLine();
            //Console.WriteLine("Hello, " + FirstName + " " + SecondName);
            Console.WriteLine($"Hello, {FirstName} {SecondName}");

        }
    }
}
