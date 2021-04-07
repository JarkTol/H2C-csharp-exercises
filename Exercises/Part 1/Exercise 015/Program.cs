using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string");
            string Word = Console.ReadLine();
      Console.WriteLine("Give a integer");
            int Num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give a double");
            double Doub = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give a boolean");
            bool Lean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your string is " + Word);
            Console.WriteLine("Your integer is " + Num);
            Console.WriteLine("Your double is " + Doub);
            Console.WriteLine("Your boolean is " + Lean);
            Console.ReadLine();

    }
  }
}
