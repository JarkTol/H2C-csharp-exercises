using System;

namespace exercise_38
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
                    while (true)
                    {
                        if (Number < 0)
                        {
                            Count = Count + 1;
                            break;
                        }                 
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Total amount of negative numbers: " + Count);
                    break;
                }
            }
            Console.ReadLine();
    }
  }
}
