// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату XA : ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату YA : ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату ZA : ");
int ZA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату XB : ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату YB : ");
int YB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату ZB : ");
int ZB = Convert.ToInt32(Console.ReadLine());
double resX = Math.Pow(XA - XB, 2);
double resY = Math.Pow(YA - YB, 2);
double resZ = Math.Pow(ZA - ZB, 2);
double res = Math.Sqrt(resX + resY + resZ);
Console.WriteLine($"{res:f2}");
