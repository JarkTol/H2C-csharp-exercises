using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
        
            PrintUntilNumber(100);
            Console.ReadLine();
    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
        {
            for (int count = 1; count <= number; count++)
            {
                Console.WriteLine(count);
            }
        } 
  }
}
