using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
        list.Add(input);
      }
      int smallest = list[0];

      for(int i = 0; i < list.Count; i++) {
       int number = list[i];
       if (smallest > number) {
        smallest = number;
        int index = list.IndexOf(smallest);
        if (index != -1);
        for (int i = 0; i <list.Count; i++)
          {
            int number = list[i];
            if (smallest == number)
            {
       }
      }

       Console.WriteLine("The smallest number: " + smallest);
       Console.WriteLine(" is at index " + i );
    }
  }
}
 }
}
