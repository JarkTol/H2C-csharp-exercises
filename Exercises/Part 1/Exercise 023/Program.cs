using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {
            
        Console.WriteLine("Give the first number");
        int First = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number");
        int Second = Convert.ToInt32(Console.ReadLine());
        int Add = First + Second;
        int Subtract = First - Second;
        int Multiply = First * Second;
        double Division = Convert.ToDouble(First) / Convert.ToDouble(Second);
        Console.WriteLine(First + " + " + Second + " = " + Add);
        Console.WriteLine(First + " - " + Second + " = " + Subtract);
        Console.WriteLine(First + " * " + Second + " = " + Multiply);
        Console.WriteLine(First + " / " + Second + " = " + Division);
        Console.ReadLine();
        
        }

  }
}
