using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Algorithm7
{
    class Print
    {
        const int N = 5;
        const int M = 7;
        public static void PrintSimple(int n, int m, int[,] a)
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

        public static void PrintWithBarriers(int n, int m, int[,] a)
        {
            Console.WriteLine("\n================================================================");
            Console.WriteLine("Количество маршрутов с припятствиями");
            int i, j;
            for (i = 0; i<n; i++)
                {
                    Console.WriteLine("_______________________________________________________________");
                    for (j = 0; j<m; j++)
                        Console.Write(" | " + String.Format("{0,3}", a[i, j]) + " | ");
                    Console.Write("\r\n");
                }
            Console.WriteLine($"количество путей до правой нижней клетки = {a[N - 1, M - 1]}");
            }
    }
}
