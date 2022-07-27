using System;

namespace Chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("CHAPTER 7");
            Console.WriteLine("----------- ");
            Console.WriteLine("1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.");
            Console.WriteLine(" ");
            int[] integer = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
             Console.Write("output: ");
             //Multiplying each element by 5
            for (int i = 0; i < integer.Length; i++)
            {
                integer[i] = 5 * integer[i];
                Console.Write(integer[i] + " ");
            }*/

            Console.WriteLine("2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).");
            Console.WriteLine(" ");
            Console.Write("Enter the length of the first array: ");
            int n = int.Parse(Console.ReadLine());
            int[] Array1 = new int[n];
            Console.Write("Enter the length of the second array: ");
            int y = int.Parse(Console.ReadLine());
             int[] Array2 = new int[y];
            if (Array1 == Array2)
            {
                Console.WriteLine("Arrays are equal.");
            }

            Console.WriteLine("4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.");
            Console.WriteLine(" ");

            
            

            
        }
    }
}
