using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int Count = 0; Count <= Number; Count++)
                Console.WriteLine(Count);
        
        Console.WriteLine("Give a number");
            int While = Convert.ToInt32(Console.ReadLine());
            int Count2 = 0;
            while (Count2 <= While)
            {
                Console.WriteLine(Count2);
                Count2 = Count2 + 1;
            }
            Console.ReadLine();


    }
  }
}
