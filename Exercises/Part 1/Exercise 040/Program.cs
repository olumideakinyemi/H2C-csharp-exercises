using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      int count = 0;
      int sum = 0;
while (true)
{
      Console.WriteLine("Give a number:");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number == 0) 
    {
       break;         
    }       
     if (number > 0)
    {
       count = count + 1;         
       sum = sum + number;
    }
     if (number < 0 )
    {
      count = count + 1;          
       sum = sum + number;         
    }
                                  
}
Console.WriteLine("Total sum of numbers: " + sum);
Console.WriteLine("Total amount of numbers: " + count);

    }
  }
}
