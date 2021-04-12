using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number");
        int Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input another number");
        int Number2 = Convert.ToInt32(Console.ReadLine());
            
            double Square = Math.Sqrt(Number + Number2);
            Console.WriteLine(Square);
            Console.ReadLine();

    }
  }
}
