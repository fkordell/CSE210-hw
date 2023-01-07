using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string name1 = Console.ReadLine();
        Console.WriteLine($"Yuor name is {name1}, {name} {name1}.");
    }
}
