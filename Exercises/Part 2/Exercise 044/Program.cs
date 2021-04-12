using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

        Console.WriteLine("Input first number");
            int First = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second number");
            int Second = Convert.ToInt32(Console.ReadLine());

            if (First > Second)
            { 
            Console.WriteLine(First + " is greater than " + Second);
            }
            else if (First < Second)
            {
            Console.WriteLine(First + " is less than " + Second);
            }
            else
            { 
            Console.WriteLine(First + " is equal to " + Second);
            }
            Console.ReadLine();
    }
  }
}
