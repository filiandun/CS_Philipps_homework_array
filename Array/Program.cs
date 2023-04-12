using System;
using System.Reflection.Metadata.Ecma335;

/*
1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
2. Преобразовать массив так, чтобы сначала шли все 
отрицательные элементы, а потом положительные 
(0 считать положительным)
3. Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число 
встречается в массиве.
4. В двумерном массиве порядка M на N поменяйте 
местами заданные столбцы
 */

namespace Array
{
    internal class Program
    {
        static void Function1()
        {
            var randomNum = new Random();

            const int SIZE = 10;
            int[] array = new int[SIZE];

            Console.Write("Исходный массив: ");
            for (int i = 0; i < SIZE; ++i)
            {
                array[i] = randomNum.Next(0, 5);
                Console.Write($"{array[i]} ");
            }

            int buf = 0;
            for (int i = 0; i < SIZE; ++i)
            {
                if (i + 2 <= SIZE && (array[i] == 0 || buf > 0))
                {
                    array[i] = array[i + 1];
                    ++buf;

                }
            }

            Console.Write($"\nB: {buf}");
            Console.Write("\nСжатый массив:   ");
            for (int i = SIZE - buf - 1; i < SIZE; ++i)
            {
                array[i] = -1;
            }

            for (int i = 0; i < SIZE; ++i)
            {
                Console.Write($"{array[i]} ");
            }
        }



        static void Function2()
        {
            var randomNum = new Random();
        }



        static void Function3()
        {
            var randomNum = new Random();

            const int SIZE = 20;
            int[] array = new int[SIZE];

            int userNumber;
            int result = 0;

            Console.Write("Введите число: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Массив: ");
            for (int i = 0; i < SIZE; ++i)
            {
                array[i] = randomNum.Next(0, 10);
                Console.Write($"{array[i]} ");
            }
            
            for (int i = 0; i < SIZE; i++)
            {
                if (array[i] == userNumber)
                {
                    ++result;
                }
            }
            Console.Write($"\n\nЧисло {userNumber} повторяется в массиве {result} раз(-а)");
        }



        static void Function4()
        {
            var randomNum = new Random();

            const int SIZE = 5;
            int[,] array = new int[SIZE, SIZE];
            int[] arrayTemp = new int[SIZE];

            int row1;
            int row2;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < SIZE; ++i)
            {
                Console.Write($"{i + 1}   ");
                for (int j = 0; j < SIZE; ++j)
                {
                    array[i, j] = randomNum.Next(0, 10);
                    Console.Write($"{array[i, j]} ");

                }
                Console.WriteLine();
            }

            Console.Write("\nВведите номер первой строки: ");
            row1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер второй строки: ");
            row2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nИзмённый массив: ");
            --row1; --row2;
            for (int i = 0; i < SIZE; ++i)
            {
                Console.Write("    ");
                for (int j = 0; j < SIZE; ++j)
                {
                    arrayTemp[j] = array[row1, j];
                    array.SetValue(array.GetValue(row2, j), row1, j);
                    //array[row1, j] = array[row2, j];
                    array[row2, j] = arrayTemp[j];
                    /*
                     * ЕСЛИ ВЫВОДИТЬ СРАЗУ ТУТ МАССИВ, ТО ОН ВЫВОДИТ С НЕИЗМЕНЁННОЙ ВТОРОЙ СТРОКОЙ 
                     * ЕСЛИ ПОТОМ ОТДЕЛЬНО В ЦИКЛЕ, ТО ВСЁ НОРМАЛЬНО
                     * МОЖЕТ НУЖНО ПОИГРАТЬСЯ С GETVALUE И SETVALUE, ТАК КАК МНОГОМЕРНЫЙ МАССИВ - ЭТО ОБЪЕКТ КЛАССА ARRAY
                     * 
                     * 
                     */

                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nВременный массив: ");
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("    ");
                for (int j = 0; j < SIZE; ++j)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }



        static void Main()
        {
            //Function1();
            //Function2();
            //Function3(); // сделано
            Function4(); // почти



        }
    }
}