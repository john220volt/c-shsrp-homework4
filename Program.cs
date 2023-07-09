﻿﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] mass)
{
    System.Console.WriteLine("Так выглядит введённый вами массив:");
    System.Console.Write("[ ");
    System.Console.Write(string.Join(" | ", mass));
    System.Console.Write(" ]");
}

//----------------------------------------------------------------------------------------------

int length = ReadInt("Введите размер массива: ");
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = ReadInt("Введите элемент массива: ");
}

PrintArray(array);