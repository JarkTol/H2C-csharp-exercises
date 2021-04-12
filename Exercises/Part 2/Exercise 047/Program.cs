using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
        //Section 1
        Console.WriteLine("Where to?");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int Count = 1; Count <= Number; Count++)
                {
                Console.WriteLine(Count);
                }

        //Section 2
        Console.WriteLine("Where to?");
            int Number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Where from?");
            int Number2 = Convert.ToInt32(Console.ReadLine());

                for (Number2 = Number2; Number2 <= Number1; Number2++)
            { 
                Console.WriteLine(Number2);
            }

                Console.ReadLine();
                
          
      
    }
  }
}
