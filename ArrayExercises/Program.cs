using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**elements of array somrInts**");
            int[] someInts = { 1, 1, 2, 3, 5, 8 };
            foreach (int i in someInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**odd numbers**");
            foreach (int j in someInts)
            {

                if (j % 2 != 0)
                Console.WriteLine(j);
            }
            Console.ReadLine();

        }
    }
}
