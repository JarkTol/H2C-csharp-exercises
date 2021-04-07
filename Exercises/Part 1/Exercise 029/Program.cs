using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number");
        int First = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number");
        int Second = Convert.ToInt32(Console.ReadLine());

        if (First == Second)
            {
                Console.WriteLine("They are equal!");
            }
        else

        if (First > Second)
            {
                Console.WriteLine("The larger number is " + First);
            }
        else
            {
                Console.WriteLine("The larger number is " + Second);
            }
        Console.ReadLine();
    }
  }
}
