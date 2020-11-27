using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUnitNumber(5);
  
    }

    // Write your method here:
    public static void PrintUnitNumber(int number){
    {
     int count = 1;
     do
     {
         Console.WriteLine(count);
         count++;
    }
     while (count <= number);
    }
  }
  }  
}

