// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Сколько чисел будет в массиве?");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
{
    Console.WriteLine("Введите элемент массива:");
    int a = Convert.ToInt32(Console.ReadLine());
    array [i]= a;
}
foreach (int i in array)
{
    Console.Write(i);
}
}
else
{
    Console.WriteLine("Массив из 8 элементов и не больше!");
}