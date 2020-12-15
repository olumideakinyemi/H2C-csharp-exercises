using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here

      int[] numbers = new int[4];

      numbers[0] = 12;
      numbers[1] = 42;
      numbers[2] = 37;
      numbers[3] = 9;

      Console.WriteLine("The array has " + numbers.Length + " elements:");
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine(numbers[i]);
      }

    }

    //public static void PrintNeatly(int[] array)
    //{

    //}
  }
}

