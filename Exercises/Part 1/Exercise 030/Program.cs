using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            
            Console.WriteLine("Give your percent [0 - 100]:");
            
            int Score = Convert.ToInt32(Console.ReadLine());

            bool Imbossible = (Score < 0);
            bool Fail = (Score >= 0);
            bool One = (Score >= 50);
            bool Two = (Score >= 60);
            bool Three = (Score >= 70);
            bool Four = (Score >= 80);
            bool Five = (Score >= 90);
            bool Out = (Score > 100);

            
            if (Imbossible)
            {
                Console.WriteLine("Imbossible");
            }
            
            else if (Fail != One)
            {
                Console.WriteLine("Fail");
            }

            else if (One != Two)
            {
                Console.WriteLine("1");
            }

            else if (Two != Three)
            {
                Console.WriteLine("2");
            }

            else if (Three != Four)
            {
                Console.WriteLine("3");
            }

            else if (Four != Five)
            {
                Console.WriteLine("4");
            }

            else if (Five != Out)
            {
                Console.WriteLine("5");
            }

            else
            {
                Console.WriteLine("Outstanding!");
            }

            Console.ReadKey();
    }

  }
}
