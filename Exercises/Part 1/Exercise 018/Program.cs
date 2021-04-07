using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the third number");
            int Third = Convert.ToInt32(Console.ReadLine());
            int Sum = (First + Second + Third);
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
    }

  }
}
