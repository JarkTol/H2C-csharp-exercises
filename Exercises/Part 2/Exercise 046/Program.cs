using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number");
        int Number = Convert.ToInt32(Console.ReadLine());

            while (Number <= 100)
            {
                Console.WriteLine(Number);
                Number = Number + 1;
            }

            Console.ReadLine();
    }
  }
}
