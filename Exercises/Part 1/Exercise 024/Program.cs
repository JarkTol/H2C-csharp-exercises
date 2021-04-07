using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give your speed");
      int Speed = Convert.ToInt32(Console.ReadLine());
      if (Speed > 120)
      {  
                Console.WriteLine("Speeding!");
        }
      Console.ReadLine();
      
    }
  }
}
