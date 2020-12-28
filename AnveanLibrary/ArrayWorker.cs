using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanLibrary
{
   public class ArrayWorker
    {
        //Поиск индекса числа в массиве
        static void Find(int[] array, int nubmer)
        {
            string index = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == nubmer)
                {
                    index += Convert.ToString(i) + " ";

                }
            }
            Console.WriteLine($"Индексы числа {nubmer} = {index} ");
        }


        //Сортивровка двумерного массива по столбцам или по строкам
        private static void SortCOL(int[,] arr, int ROW, int COL)
        {
            // ROW COL должны быть константы. (Строки, Столбцы)
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL - 1; j++)
                {
                    for (int k = 0; k < COL - j - 1; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1]) //Если поменять знак, поменяется и сортировка
                        {
                            int temp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = temp;
                        }
                    }
                }
            }
        }


        //Обычная сортировка массива Пузырьком
        private static void Sort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }


        //Заполнение 1(2) мерного массива случайными числами
        private static void Fill(int[,] matrix)
        {
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100);
                }
            }
        }


        //Заполнение 2мерного массива ЗМЕЙКОЙ 1 2 3 4 5
        //                                   10 9 8 7 6
       static void FillSnake(int[,] array)
        {
            int n = array.GetLength(0), m = array.GetLength(1);
            for (int i = 0, v = 0; i < n + m - 1; i++)
            {
                int r, c;
                if (i % 2 == 1)
                {
                    r = i < m ? 0 : i - m + 1;
                    c = i < m ? i : m - 1;
                }
                else
                {
                    r = i < n ? i : n - 1;
                    c = i < n ? 0 : i - n + 1;
                }
                while (r < n && r >= 0 && c < m && c >= 0)
                {
                    array[i % 2 == 0 ? r-- : r++, i % 2 == 0 ? c++ : c--] = ++v;
                }
            }
        }


        //Вывод массива 1(2) мерного
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }

            Console.WriteLine();
        }


        //Нахождение минимального числа в массиве []/[,]
        private static int Min(int[,] matrix)
        {
            var min = int.MaxValue;

            foreach (var value in matrix)
            {
                if (min > value) min = value;
            }

            return min;
        }


        //Нахождение максимального числа в массиве []/[,]
        private static int Max(int[,] matrix)
        {
            var max = int.MinValue;

            foreach (var value in matrix)
            {
                if (value > max) max = value;
            }

            return max;
        }


        //Поиск индекса по ссылке ПРИМЕР В КОММЕНТАРИЯХ МЕТОДА
        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
                }
            }
            throw new IndexOutOfRangeException("число не найдено");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
            //numberRef = 9; // заменяем 4 на 9
            //Console.WriteLine(numbers[3]); // 9

            //Console.Read();
        }
    }

}

