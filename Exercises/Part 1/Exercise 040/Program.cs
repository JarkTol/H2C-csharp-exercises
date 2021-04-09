using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
    int Count = 0;
    int NumCount = 0;
            
            while (true)
            {
                Console.WriteLine("Give a number:");
                int Number = Convert.ToInt32(Console.ReadLine());
                
                if (Number != 0)
                {                       
                    Count = Count + Number;
                    NumCount = NumCount + 1;
                }

                else
                {
                   Console.WriteLine("Total sum of numbers: " + Count);
                   Console.WriteLine("Total amount of number:" + NumCount);
                    break;
                }
            }
      Console.ReadLine();
    }
  }
}
