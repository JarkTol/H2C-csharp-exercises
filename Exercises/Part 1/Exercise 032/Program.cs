﻿using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Speak, friend, and enter!");

            string Word = Console.ReadLine();

            if (Word == "Mellon")
            {
                Console.WriteLine("Welcome, friend!");
            }

            else
            {
                Console.WriteLine("They've got a cave troll!");
            }

            Console.ReadKey();

    }
  }
}
