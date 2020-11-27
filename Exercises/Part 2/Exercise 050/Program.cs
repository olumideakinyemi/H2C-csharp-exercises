using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int userInput = Convert.ToInt32(Console.ReadLine());
      int numOftimes = 0;
      while(userInput > numOftimes)
      {
        PrintPhrase();
        numOftimes++;
      }  
 
    } // Write your method here:
    public static void PrintPhrase() {
    {
      Console.WriteLine("In a hole in the ground there lived a method");  
    
    }
    }
  }
}
