using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("From where?");
      int inputuserFrom = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
      int inputuserTo = Convert.ToInt32(Console.ReadLine());
      PrintSmallerThan(list, inputuserTo);
    }

    public static void PrintSmallerThan(List<int> numbers, int threshold) 
       {
         foreach(int number in numbers)
       {
       if (number < threshold) 
       {
        Console.WriteLine(number);
       }
    }
  }
  }
}
