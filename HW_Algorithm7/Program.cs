using System;

namespace HW_Algorithm7
{
    class Program
    {
        const int N = 5;
        const int M = 7;

        public class TestCase
        {
            public int IndexM { get; set; }
            public int IndexN { get; set; }
            public int Answer { get; set; }
        }

        static void Main(string[] args)
        {

            int[,] A = new int[N, M];
            int[,] W = new int[N, M];

            int[,] realizedA = Rectangle.SimpleNumberOfPaths(N, M, A);
            int[,] realizedB = Rectangle.NumberOfPathsWithBarriers(N, M, W);

            Console.WriteLine("\n\nТест на правильность выполнения работы по количеству маршрутов без препятствий:");

            //Проверка без препятствий
            var testData = new TestCase[2];

            testData[0] = new TestCase()
            {
                IndexM = 1,
                IndexN = 2,
                Answer = 3
            };
            testData[1] = new TestCase()
            {
                IndexM = 3,
                IndexN = 2,
                Answer = 10
            };

            foreach (var testCase in testData)
            {
                var result = testCase.Answer;
                var expected = realizedA[testCase.IndexN, testCase.IndexM];
                if (result == expected)
                {
                    Console.WriteLine("Все верно!");
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }

            Console.WriteLine("\n\nТест на правильность выполнения работы по количеству маршрутов c препятствиями:");

            //Проверка с препятствиями
            var testData2 = new TestCase[2];

            testData2[0] = new TestCase()
            {
                IndexM = 2,
                IndexN = 1,
                Answer = 3
            };
            testData2[1] = new TestCase()
            {
                IndexM = 3,
                IndexN = 3,
                Answer = 0
            };


            foreach (var testCase in testData2)
            {
                var result = testCase.Answer;
                var expected = realizedB[testCase.IndexN, testCase.IndexM];
                if (result == expected)
                {
                    Console.WriteLine("Все верно!");
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
        }
    }
}
