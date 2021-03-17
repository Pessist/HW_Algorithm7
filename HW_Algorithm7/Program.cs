using System;

namespace HW_Algorithm7
{
    class Program
    {
        const int N = 5;
        const int M = 7;

        
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



            Print.PrintSimple(N, M, A);

            Print.PrintWithBarriers(N, M, W);
        }
    }
}
