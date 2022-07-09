using System;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int age;
            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + "!"
                            + " You can vote");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!"
                    + " Sorry you can't vote");
            }


        }
    }
}