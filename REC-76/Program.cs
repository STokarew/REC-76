using System;

namespace REC_76
{
    class Program
    {
        private static int[,] Matrix(int n, int m)
        {
            int[,] ARR = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ARR[i, j] = 0;
                }
            }
            return ARR;
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            var Row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            var Column = int.Parse(Console.ReadLine());
            PrintMatrix(Matrix(Row, Column));
            Console.ReadKey();
        }
    }
}
