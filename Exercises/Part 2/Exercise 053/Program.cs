using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Division(34, 13);
            Console.ReadLine();

    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
        {
            double result = Convert.ToDouble(numerator / denominator);
            Console.WriteLine(result);
        }

  }
}
