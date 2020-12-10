﻿using System;
using System.Collections.Generic;

namespace exercise_70
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
      int grEatest = list[0];

      for(int i = 0; i < list.Count; i++) {
       int number = list[i];
       if (grEatest < number) {
        grEatest = number;
       }
      }

       Console.WriteLine("The grEatest number: " + grEatest);
    }
  }
}
