using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
                Console.WriteLine("Give a number");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number == 42)
                {
                    break;
                }           
      }
      Console.ReadLine();        
    }
  }
}
