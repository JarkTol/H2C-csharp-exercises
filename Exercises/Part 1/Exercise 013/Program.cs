using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number.");
      double Input = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("You give number " + Input);
      Console.ReadLine();
    }
  }
}
