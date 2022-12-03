namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        void Task47()
        {
            /* Задача 47. Задача 47: Задайте двумерный массив размером m×n, 
            заполненный случайными вещественными числами, округлёнными до одного знака.

                m = 3, n = 4.
                0,5 7 -2 -0,2
                1 -3,3 8 -9,9
                8 7,8 -7,1 9 */
            Console.WriteLine("     - -Задача 47- -");
            Console.WriteLine("Двумерный массив заполненный случайными вещественными числами:");
            Console.WriteLine("");

            int row = 3;
            int columns = 4;
            double[,] numbersReal = new double[row, columns];

            FillArrayReal(numbersReal, -100, 1000);
            PrintArrayReal(numbersReal);
        }

        void Task50()
        {
            /* 
                Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
                и возвращает значение этого элемента или же указание, что такого элемента нет.
                Например, задан массив:
                1 4 7 2
                5 9 2 3
                8 4 2 4
                1, 3 -> 3 */
            Console.WriteLine();
            Console.WriteLine("     - -Задача 50- -");
            Console.WriteLine("  Задан двумерный массив:");
            int row = 4;
            int columns = 4;
            int[,] number = new int[row, columns];
            FillArray(number, 0, 10);
            PrintArray(number);

            Console.Write("Введите индексы элемента через пробел: ");
            string container = Console.ReadLine();
            string[] numberS = container.Split();

            int rowCont = Convert.ToInt32(numberS[0]);
            int columnsCont = Convert.ToInt32(numberS[1]);
            if (rowCont <= row && columnsCont <= columns) Console.WriteLine($" [{rowCont}, {columnsCont}] -> {number[rowCont, columnsCont]}");
            else Console.WriteLine($"В двумерном массиве по индексам [{rowCont}, {columnsCont}] элемента нет!");
        }

        void Task52()
        {
            /* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                Например, задан массив:
                    1 4 7 2
                    5 9 5 3
                    8 4 6 4
                Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.*/
            Console.WriteLine();
            Console.WriteLine("     - -Задача 52- -");
            Console.WriteLine("  Задан двумерный массив:");
            int row = 3;
            int columns = 4;
            int[,] number = new int[row, columns];
            FillArray(number, 0, 10);
            PrintArray(number);
            int sum = 0;
            double[] result = new double[columns];
            Console.Write("Среднее арифметическое каждого столбца: -> ");

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    sum = sum + number[i, j];
                }
                result[j] = sum;
                sum = 0;
                Console.Write($"  {Math.Round((result[j]/row), 1)}");
                //Console.Write($" {Math.Round((result / row), 1)}");
            }
            Console.WriteLine();




        }

        void FillArray(int[,] numbers, int minValue, int maxValue)
        {
            maxValue++;
            Random rand = new Random();
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }

        void FillArrayReal(double[,] numbersReal, int minValue, int maxValue)
        {
            maxValue++;
            Random rand = new Random();
            int row = numbersReal.GetLength(0);
            int columns = numbersReal.GetLength(1);
            int[,] numbers = new int[row, columns];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rand.Next(minValue, maxValue);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbersReal[i, j] = Math.Round(Convert.ToDouble(numbers[i, j]), 1) / 10;
                }
            }

        }

        void PrintArray(int[,] numbers)
        {
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Console.Write($"A[{i}, {j}] = {numbers[i, j]}    ");
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        void PrintArrayReal(double[,] numbers)
        {
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Console.Write($"A[{i}, {j}] = {numbers[i, j]}    ");
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
        }


        Task47(); //Задача 47 
        Task50(); //Задача 50 
        Task52(); //Задача 52 
    }
}
