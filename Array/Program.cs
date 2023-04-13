using System;

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

            for (int i = 0; i < SIZE; ++i)
            {
                if (array[i] == 0) 
                {
                    for (int j = i; j < SIZE - 1; ++j)
                    {
                        array[j] = array[j + 1];
                        array[j + 1] = -1;
                    }
                    i--; // нужно для того, чтобы в случае массива, в котором нули идут подряд, он их не пропустил
                }
            }

            Console.Write("\nСжатый массив:   ");
            for (int i = 0; i < SIZE; ++i)
            {
                Console.Write($"{array[i]} ");
            }
        }




        static void Function2()
        {
            var randomNum = new Random();

            const int SIZE = 15;
            int[] array = new int[SIZE];
            int temp;

            Console.Write("Исходный массив: ");
            for (int i = 0; i < SIZE; ++i)
            {
                array[i] = randomNum.Next(-9, 9);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < SIZE; ++i)
            {
                for (int j = 0; j < SIZE - i - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.Write("\nОтсортированный массив: ");
            for (int i = 0; i < SIZE; ++i)
            {
                Console.Write($"{array[i]} ");
            }
        }




        static void Function3()
        {
            var randomNum = new Random();

            const int SIZE = 20;
            int[] array = new int[SIZE];

            int userNumber;
            int count = 0;

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
                    ++count;
                }
            }
            Console.Write($"\n\nЧисло {userNumber} повторяется в массиве {count} раз(-а)");
        }




        static void Function4()
        {
            var randomNum = new Random();

            const int SIZE = 5;
            int[,] array = new int[SIZE, SIZE];

            int temp;

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

            --row1; --row2;
            for (int i = 0; i < SIZE; ++i)
            {
                for (int j = 0; j < SIZE; ++j)
                {
                    temp = array[row1, j];
                    array.SetValue(array.GetValue(row2, j), row1, j);
                    array.SetValue(temp, row2, j);

                    /* Console.Write($"{array[i, j]} ");
                     * ЕСЛИ ВЫВОДИТЬ СРАЗУ ТУТ МАССИВ, ТО ОН ВЫВОДИТСЯ С НЕИЗМЕНЁННОЙ ВТОРОЙ СТРОКОЙ 
                     * ЕСЛИ ПОТОМ ОТДЕЛЬНО В ЦИКЛЕ, ТО ВСЁ НОРМАЛЬНО
                     * МОЖЕТ НУЖНО ПОИГРАТЬСЯ С GETVALUE И SETVALUE, ТАК КАК МНОГОМЕРНЫЙ МАССИВ - ЭТО ОБЪЕКТ КЛАССА ARRAY
                    */
                }
            }

            Console.WriteLine("\nИзменённый массив: ");
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
            Function1();
            //Function2();
            //Function3();
            //Function4();
        }
    }
}