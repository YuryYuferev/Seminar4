﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)    2, 4 -> 16
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число A");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите число B");

        int b = Convert.ToInt32(Console.ReadLine());

        int step = a;

        for (int i = 1; i < b; i++)
        {
            step = step * a;
        }
        Console.WriteLine("A в степени B равно: " + step);
    }
}
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11     82 ->10   9012 -> 12
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число");

        int i = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        while (i > 0)
        {
            int num = i % 10;

            i = i / 10;

            sum = sum + num;
        }
        Console.WriteLine("Cумма всех цифр в числе равна: " + sum);
    }
}
*/
// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]       6, 1, 33 -> [6, 1, 33]

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Создаём массив с элементами от 1 до 99");
        Console.Write("Введите любое число (размер массива): ");
        int Number = Convert.ToInt32(Console.ReadLine());

        Console.Write("[");
        int[] array = new int[Number];

        for (int i = 0; i < Number; i++)
        {
            array[i] = new Random().Next(1, 100);
            Console.Write(array[i] + ";");
        }
            Console.Write("]");
        
        Console.WriteLine();
    }
}

