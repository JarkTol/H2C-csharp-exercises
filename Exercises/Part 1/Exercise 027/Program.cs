using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      int Number = Convert.ToInt32(Console.ReadLine());
      if (Number >= 0)
      {  
                Console.WriteLine("It is positive");
        }
      else
            {
                Console.WriteLine("It is not positive");
            }
      Console.ReadLine();
    }
  }
}
