using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Give the first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            int Sum = (First * Second);
            Console.WriteLine(First + " * " + Second + " = " + Sum);
            Console.ReadLine();

    }
  }
}
