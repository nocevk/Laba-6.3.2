using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6._3._2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[,] matrix = new int[6, 4];

                FillMatrix(matrix);
                Console.WriteLine("Generated Matrix:");
                PrintMatrix(matrix);

                int minColumnIndex;
                int minColumnSum = FindMinSumColumn(matrix, out minColumnIndex);

                Console.WriteLine($"\nColumn with minimum sum is: {minColumnIndex}");
                Console.WriteLine($"Minimum sum in the column is: {minColumnSum}");
            }

          
            static void FillMatrix(int[,] matrix)
            {
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(0, 101);
                    }
                }
            }

                 
            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j],4}");
                    }
                    Console.WriteLine();
                }
            }

            static int FindMinSumColumn(int[,] matrix, out int minColumnIndex)
            {
                int minSum = int.MaxValue;
                minColumnIndex = -1;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int columnSum = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        columnSum += matrix[i, j];
                    }

                    if (columnSum < minSum)
                    {
                        minSum = columnSum;
                        minColumnIndex = j;
                    }
                }

                return minSum;
            }
        
    }
}

                
           

        
    


