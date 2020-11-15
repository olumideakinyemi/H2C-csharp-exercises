using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {
      int input = Convert.ToInt32(Console.ReadLine()); 
      int number = 0;
      //input = number;

      while (number <= input) 
      {
      Console.WriteLine(number);
      number++;
      }
      
    }
  }
}

