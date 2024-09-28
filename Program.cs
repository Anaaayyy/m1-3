using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1_3
{
    internal class Program
    {
        // Метод для вычисления НОД
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Общий делитель двух целых натуральных чисел -----------");
            Console.Write("Введите числитель (неотрицательный): ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель (положительный): ");
            int denominator = int.Parse(Console.ReadLine());

            if (denominator <= 0)
            {
                Console.WriteLine("Знаменатель должен быть положительным.");
                return;
            }

            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
            Console.ReadLine();






            Console.WriteLine("-------------Массив с минимальным количеством элементов-----------");
            Console.Write("Введите число: ");
            int targetSum = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] array = new int[0];
            int currentSum = 0;

            while (currentSum < targetSum)
            {
                int nextValue = rand.Next(1, 10); // случайное значение от 1 до 9

                // Проверяет, не превысит ли сумма целевое значение после добавления nextValue
                if (currentSum + nextValue <= targetSum)
                {
                    currentSum += nextValue;

                    // Добавляет элемент в массив
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = nextValue;
                }
            }

            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
            Console.ReadLine();







            Console.WriteLine("-------------Квадратная целочисленная матрица-----------");
                Random random = new Random();

                // Ввод размера матрицы
                Console.Write("Введите размер матрицы: ");
                int n = int.Parse(Console.ReadLine());

                // Создание и заполнение матрицы случайными значениями от -50 до +50
                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(-50, 51);
                    }
                }

                // Вывод исходной матрицы
                Console.WriteLine("Исходная матрица:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Сортировка строк по возрастанию суммы элементов
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        int sum1 = 0, sum2 = 0;
                        for (int k = 0; k < n; k++)
                        {
                            sum1 += matrix[i, k];
                            sum2 += matrix[j, k];
                        }

                        if (sum1 > sum2)
                        {
                            // Меняем строки местами
                            for (int k = 0; k < n; k++)
                            {
                                int temp = matrix[i, k];
                                matrix[i, k] = matrix[j, k];
                                matrix[j, k] = temp;
                            }
                        }
                    }
                }

                // Вывод отсортированной матрицы
                Console.WriteLine("\nМатрица после сортировки строк по возрастанию суммы элементов:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }

