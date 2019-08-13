using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static void PrintArray(int[,] arr, int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void FillArray(int[,] arr, int width, int height)
        {
            int buffer = 0;
            for (int i = 0; i < width; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < height; j++)
                    {
                        arr[i, j] = buffer++;
                    }
                }
                else
                {
                    for (int j = width - 1; j >= 0; j--)
                    {
                        arr[i, j] = buffer++;
                    }
                }
            }
        }
               static void Main(string[] args)
        {
            var width = 5;
            var height = 5;
            int arr[i,j] = new int arr [i,j];
            FillArray(arr, width, height);
            PrintArray(arr, width, height);
            

            Console.ReadKey();
        }
    }
}
