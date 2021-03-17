using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Algorithm7
{
    class Rectangle
    {
        public static int[,] SimpleNumberOfPaths(int N, int M, int[,] A)
        {
            A = new int[N, M];
            int i, j;

            for (j = 0; j < M; j++)
                A[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }

            Print.PrintSimple(N, M, A);

            return A;
        }

        public static int[,] NumberOfPathsWithBarriers(int N, int M, int[,] W)
        {
            W = new int[N, M];
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

            for (i = 1; i < N; i++)
            {
                for (j = 1; j < M; j++)
                {
                    if (W[i, j] == 1)
                    {
                        W[i, j] = W[i - 1, j] + W[i, j - 1];
                    }
                    if (W[i, j] == 0)
                    {
                        W[i, j] = 0;
                    }
                }

            }

            Print.PrintWithBarriers(N, M, W);

            return W;
        }
    }
}
