using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first string:");

            string String1 = Console.ReadLine();

        Console.WriteLine("Give the second string");

            string String2 = Console.ReadLine();

            if (String1 == String2)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }
            Console.ReadLine();
    }
  }
}
