using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n\n" + "What is your name?\n");
            string Name = Console.ReadLine();

            Console.WriteLine("\nWhat is your profession?\n");
            string Profession = Console.ReadLine();

            Console.WriteLine("\nHere is the story:\n" + "\nOnce upon a time there was a " + Profession + " called " + Name + ".");
            Console.WriteLine("On him/her way to work, " + Name + " often pondered what being " + Profession + " meant to them.");
            Console.WriteLine("When you work as a " + Profession + " you meet interesting people.");
            Console.WriteLine(Name + " enjoys their work as " + Profession + ", The end.");

            Console.ReadLine();

        }
    }
}
