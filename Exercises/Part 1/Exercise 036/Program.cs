using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
                Console.WriteLine("Give a number");
                int Number = Convert.ToInt32(Console.ReadLine());

                if (Number > 0)
                {
                    Number = Number * Number;
                    Console.WriteLine(Number);
                }
                
                else if (Number <0)
                {
                    Console.WriteLine("That is negative");
                }
                
                else if (Number == 0)
                {
                    break;
                }

      }
      Console.ReadLine();
    }
  }
}
