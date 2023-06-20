// See https://aka.ms/new-console-template for more information

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите значение координат первой точки");
int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
Console.WriteLine("Введите значение координат второй точки");
int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
Console.WriteLine("расстояние между ними в 3D пространстве = "
                + Math.Sqrt(Math.Pow(b[0] - a[0],2) + 
                            Math.Pow(b[1] - a[1],2) +
                            Math.Pow(b[2] - a[2],2)
                           )
                 );
