﻿using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Console.WriteLine("Give numerator!");
      int numerator = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give denominator!");
      int denomirator = Convert.ToInt32(Console.ReadLine());
      double divresult = Division(numerator,denomirator);
      Console.WriteLine(divresult);
    }

    // Write your method here:
    public static double Division(int numerator, int denomerator){
    {
      double divide = ((double) numerator/ (double) denomerator);
      return divide;   
    
    }    
        
   }
  }
}
