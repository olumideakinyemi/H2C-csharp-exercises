using System;
using System.Collections.Generic;

namespace exercise_71
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
         Console.WriteLine("Search for?");
         int userinputSearch = Convert.ToInt32(Console.ReadLine());
         int index = list.IndexOf(userinputSearch);
         if (index != -1);

         for (int i = 0; i <list.Count; i++)
          {
            int number = list[i];
            if (userinputSearch == number)
         {
           Console.WriteLine(userinputSearch + " is at index " + i );
         }
         }
            
            
        }
    }
 }


