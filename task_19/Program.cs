// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9999 && N < 100000)
{
    int i1 = N / 10000;
    int i2 = (N - i1 * 10000) / 1000;
    int i5 = N % 10;
    int i4 = (N - i5)/10 % 10;
    if (i1 == i5 && i2 == i4)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Некорректный ввод.");
}