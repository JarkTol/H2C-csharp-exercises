using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
            
            int Number = Convert.ToInt32(Console.ReadLine());
            
            if ((Number % 2) == 0)
            {
                Console.WriteLine("Number is even.");
            }
            
            else
            {
                Console.WriteLine("Number is odd.");
            }

            Console.ReadKey();
    }
  }
}
