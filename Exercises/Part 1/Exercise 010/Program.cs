using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information. Give a name for main character:");
            string Ada = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string DataScientist = Console.ReadLine();
            Console.WriteLine("Here is the story:Once upon a time there was a Data Scientist called Ada\n" + 
                "On her way to work, Ada often pondered what being Data Scientist meant to them.\n" +  
                "When you work as a Data Scientist you meet interesting people.\n" + 
                "Ada enjoys their work as Data Scientist, The end.");

        }
    }
}
