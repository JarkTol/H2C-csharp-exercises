using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Section 1

      Console.WriteLine("Give numbers");
      while (true)
      {            
            int Number = Convert.ToInt32(Console.ReadLine());
                
                if (Number == -1)
                {
                    Console.WriteLine("Thx! Bye!");
                    break;
                }
      }
      
            Console.ReadLine();

        
            
      //Section 2

       Console.WriteLine("Give numbers");
       int Calc = 0;
        
      while (true)
      { 
            int Number = Convert.ToInt32(Console.ReadLine());
                    
                if (Number == -1)
                {
                    Console.WriteLine("Thx! Bye!\n" + "Sum: " + Calc);
                    break;
                }
                
                else
                {
                    Calc = Calc + Number;
                }
      }
    
            Console.ReadLine();

        
            
       //Section 3

       Console.WriteLine("Give numbers");
       Calc = 0;
       int Count = 0;
        
      while (true)
      { 
            int Number = Convert.ToInt32(Console.ReadLine());
                    
                if (Number == -1)
                    {
                    Console.WriteLine("Thx! Bye!\n" + "Sum: " + Calc + 
                                      "\nNumbers: " + Count);
                    break;
                    }
                
                else
                {
                    Calc = Calc + Number;
                    Count = Count + 1;
                }
      }
    
            Console.ReadLine();

        //Section 4

        Console.WriteLine("Give numbers");
        Calc = 0;
        Count = 0;
        double AverageCount = 0;
        
      while (true)
      { 
            int Number = Convert.ToInt32(Console.ReadLine());
                    
                if (Number == -1)
                {
                    AverageCount = Convert.ToDouble(Calc) / Convert.ToDouble(Count);
                    Console.WriteLine("Thx! Bye!\n" + 
                                      "Sum: " + Calc + 
                                      "\nNumbers: " + Count +
                                      "\nAverage: " + AverageCount);
                    break;
                }

                else
                {
                    Calc = Calc + Number;
                    Count = Count + 1;
                }
      }
    
            Console.ReadLine();

        //Section 5

        Console.WriteLine("Give numbers");
        Calc = 0;
        Count = 0;
        AverageCount = 0;
        int Even = 0;
        int Odd = 0;
        
      while (true)
      { 
            int Number = Convert.ToInt32(Console.ReadLine());
                    
                if (Number == -1)
                {
                    AverageCount = Convert.ToDouble(Calc) / Convert.ToDouble(Count);
                    Console.WriteLine("Thx! Bye!\n" + 
                                       "Sum: " + Calc + 
                                        "\nNumbers: " + Count +
                                         "\nAverage: " + AverageCount +
                                           "\nEven: " + Even +
                                             "\nOdd: " + Odd);
                    break;
                }

                else
                {
                    Calc = Calc + Number;
                    Count = Count + 1;
                    int Remainder = Number % 2;

                    if (Remainder == 0)
                    { 
                        Even = Even + 1;
                    }
                    
                    else
                    {
                        Odd = Odd + 1;
                    }
                }
      }
    
            Console.ReadLine();
    }
  }
}
