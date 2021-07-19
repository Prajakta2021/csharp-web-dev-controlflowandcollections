using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string oldString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house.I will not eat them with a mouse.";
            
             string[] newStringArray =  oldString.Split(" ");
            foreach (string word in newStringArray)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(string.Join(",", newStringArray));

             string[] separateSent = oldString.Split(".");
            foreach (string word in separateSent)
            {
                Console.WriteLine(word);
            }
              Console.WriteLine(String.Join(",",separateSent));

              Console.ReadLine();
        }
    }
}
