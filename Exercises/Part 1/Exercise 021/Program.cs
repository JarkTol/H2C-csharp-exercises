using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            double Average = (First + Second) / 2.0;
            Console.WriteLine("The average is " + Average);
            Console.ReadLine();

    }
  }
}
