using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give days");
            int Seconds = (Convert.ToInt32(Console.ReadLine())* 60 * 60 * 24);
            Console.WriteLine(Seconds);
            Console.ReadLine();

    }
  }
}
