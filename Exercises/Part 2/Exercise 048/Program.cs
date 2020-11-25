using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give numbers:");
      int sum = 0;
      int validNumbers = 0;
      int invalidNumber = 0;
      while (true)
      {
      int input = Convert.ToInt32(Console.ReadLine());

       if (input < 0) 
      {
        
          Console.WriteLine("Tnx! Bye!");
          invalidNumber++;
          sum += input;
          break;  
      }
      
      if (input > 0)
      {

        continue;  
                  
      }  
       Console.WriteLine("sum:" + sum);
       Console.WriteLine("numbers" + invalidNumber); 
      
      }
    }
  }
}
