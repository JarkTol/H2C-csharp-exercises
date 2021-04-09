using System;

namespace exercise_39
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
                    Count = Count + Number;
                }

                else
                {
                   Console.WriteLine("Total sum of numbers: " + Count);
                    break;
                }
            }
      Console.ReadLine();
    }
  }
}
