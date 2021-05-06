using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
        
            PrintUntilNumber(10);
            Console.ReadLine();
    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
        {
            for (int count = number; count >= 1; count--)
            {
                Console.WriteLine(count);
            }
        } 
  }
}
