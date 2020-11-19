using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      int input = Convert.ToInt32(Console.ReadLine());
      int number = 100;
     
      while (input <= number)
      {
            
        Console.WriteLine(input);
        input++;
      }
    }
  }
}
