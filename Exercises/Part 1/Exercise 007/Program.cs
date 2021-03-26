using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            
            String Input = Console.ReadLine();

                for(int Counter = 0; Counter <= 2; Counter++)   //Printing Input text three times.
                {Console.WriteLine(Input);}

                Console.ReadLine();
            
        }
    }
}
