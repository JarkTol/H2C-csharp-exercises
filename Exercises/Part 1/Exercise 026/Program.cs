using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your age:");
      int Age = Convert.ToInt32(Console.ReadLine());
      if (Age <= 1899)
      {  
                Console.WriteLine("You're old");
        }
      Console.ReadLine();

    }
  }
}
