// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите вообще любое число");
int A = Convert.ToInt32(Console.ReadLine());
int Main(int arg1)
{
int sum  = 0;
for (int i = 0; i <= arg1; i++)
{
    sum = sum + (arg1 % 10);
    arg1 = arg1 / 10;
}
return sum;
}
Console.WriteLine($"Сумма всех цифр в числе {A} = {Main(A)}");
