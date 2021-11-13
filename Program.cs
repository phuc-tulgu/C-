/*
 В массиве из 10 целых чисел найти наименьший элемент и поменять его местами с последним элементом: 
*/

using System;

namespace Lab_6___CSharp
{
    class Program
    {
        public static void in_put(int [,] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" Input value of element(s) arr[{0}][{1}]: ",i+1 , j+1);
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void out_put(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i,j] + "\t" );
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            int [,] arr = new int [20,20];
            in_put(arr, n);
            out_put(arr, n);
        }
    }
}
