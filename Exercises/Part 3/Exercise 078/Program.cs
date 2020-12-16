using System;
using System.Collections.Generic;

namespace exercise_78
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
      Console.WriteLine("");
      
      
      // Implement here
      Console.WriteLine("Give two indices to swap.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            //You didnt declare an array, lets fix that
            int[] array = new int[] { input1, input2 };
            //now you have the variables saved in an array you can assign them
            input1 = array[1]; //1 is the second index so we are assigning input 2 to input 1
            input2 = array[0]; //0 is the first index so we are assigning input 1 to input 2
            Console.WriteLine(
                "\n" + input1 +
                "\n" + input2);


      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
    }

  }
}


