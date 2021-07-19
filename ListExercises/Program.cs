using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {           
          /*List<double> evenNum = new List<double>();
            string input;
            double sum = 0.0;
            double newNum;
            Console.WriteLine("Enter numbers (or ENTER to finish):");
            do
            {
              input = Console.ReadLine();
                newNum = Double.Parse(input);
                if (!Equals(newNum, ""))
                {
                    evenNum.Add(newNum);
                }

            } while (!Equals(newNum, ""));

            for(int i = 0; i<evenNum.Count; i++)
            {
                if (evenNum[i] % 2 == 0)
                {
                    Console.WriteLine("Sum of even numbers in list : " + sum + ".");
                    sum += evenNum[i];
                }
            } */
            
            List<string> newString = new List<string>();
            string newWord;
            string input;
            Console.WriteLine("Enter your words (or ENTER to finish):");
            do
            {
                input = Console.ReadLine();
                newWord = input;

                if (!Equals(newWord, ""))
                {
                    newString.Add(newWord);
                }

            } while (!Equals(newWord, ""));
              for (int i=0; i<newString.Count; i++ ) 
              {
                if (newString[i].Length == 5) {
                    Console.WriteLine(newString[i]);
                }
              }
            Console.WriteLine("Please enter the word length to search : ");
            for (int i = 0; i < newString.Count; i++)
            {               
                double wordLength = double.Parse(Console.ReadLine());
                
                if (newString[i].Length == wordLength)
                {
                    Console.WriteLine(newString[i]);
                } else {
                    Console.WriteLine("There is no word of " + wordLength +" charcters.");
                }

            }
            Console.ReadLine();

        }
    }
}
