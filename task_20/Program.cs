// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double i = Math.Pow(10,2);
// Console.WriteLine(i);

// double res = Math.Sqrt(25);
// Console.WriteLine("{res:f4}"); выводим количество знаков после , f4.

// double res = Math.Sqrt(5);
// Console.WriteLine(Math.Round(res, 5));выводим количество знаков после , 5


Console.WriteLine("Введите координату XA : ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату YA : ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату XB : ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату YB : ");
int YB = Convert.ToInt32(Console.ReadLine());
double resX = Math.Pow(XA-XB,2);
double resY = Math.Pow(YA-YB,2);
double res = Math.Sqrt(resX+resY);
Console.WriteLine($"{res:f4}");