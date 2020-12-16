using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:"); 
     
     string username = Console.ReadLine();
     
     if (username == "alex")
     {
       Console.WriteLine("Enter password:");
       
      }
      string password = Console.ReadLine();
      if (password == "sunshine")
     {
       Console.WriteLine("You have successfully logged in!");
     }
        else    
     
     {
      Console.WriteLine("Incorrect username or password!");
     }
      
    }
    }
  }
  
