using System;

namespace Lab_5_task_2
{
    public class MathProcessor
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public int[] OperateArrays(int[] arr1, int[] arr2, Func<int, int, int> operation)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = operation(arr1[i], arr2[i]);
            }
            return result;
        }

        public int[,] OperateMatrices(int[,] matrix1, int[,] matrix2, Func<int, int, int> operation)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (matrix2.GetLength(0) != rows || matrix2.GetLength(1) != cols)
                throw new ArgumentException("Matrices must have the same dimensions.");

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = operation(matrix1[i, j], matrix2[i, j]);
                }
            }
            return result;
        }
    }
}