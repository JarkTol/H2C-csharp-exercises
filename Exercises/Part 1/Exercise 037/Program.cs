using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {   

        int Count = 0;
            
            while (true)
            {
                Console.WriteLine("Give a number:");
                int Number = Convert.ToInt32(Console.ReadLine());
                
                if (Number != 0)
                {                       
                    Count = Count + 1;
                }

                else
                {
                   Console.WriteLine("Total amount of numbers: " + Count);
                    break;
                }
            }
      Console.ReadLine();
    }
  }
}
