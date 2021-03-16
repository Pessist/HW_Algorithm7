using System;

namespace HW_Algorithm7
{
    class Program
    {
        const int N = 5;
        const int M = 7;

        static void Print2(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("_______________________________________________________________");
                for (j = 0; j < m; j++)
                    Console.Write(" | " + String.Format("{0,3}", a[i, j]) + " | ");
                Console.Write("\r\n");
            }
            Console.WriteLine($"количество путей до правой нижней клетки = {a[N - 1, M - 1]}");
        }

        static void Main(string[] args)
        {
            int[,] A = new int[N, M];
            int[,] W = new int[N, M];
            int i, j;

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    W[i, j] = 1;
                    W[3, 2] = 0;
                    W[4, 4] = 0;
                    W[2, 3] = 0;
                }
            }

            for (j = 0; j < M; j++)
                A[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }



            Print2(N, M, A);

            Print2(N, M, W);
        }
    }
}
