// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else if (i == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else if (i == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else if (i == 4)
{
    Console.WriteLine("X>0, Y<0");
}
else
{
    Console.WriteLine("Неправильно введен номер координатной четверти");
}

