using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
      int Number = Convert.ToInt32(Console.ReadLine());
      if (Number >= 18)
      {  
                Console.WriteLine("You're an adult!");
        }
      else
            {
                Console.WriteLine("You're underage!");
            }
      Console.ReadLine();

    }
  }
}
