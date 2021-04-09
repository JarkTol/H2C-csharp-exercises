using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
        

      while (true)
      {
            Console.WriteLine("Do you want to continue?");
            string Answer = Console.ReadLine();

            if (Answer == "no")
            {
                break; 
            }

      }

            Console.ReadLine();
    }
  }
}
