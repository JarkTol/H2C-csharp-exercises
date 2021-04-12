using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number < 0)
            {
                Number = Number * -1;
                Console.WriteLine(Number);
            }
            else
                Console.WriteLine(Number);
            Console.ReadLine();
      
    }
  }
}
