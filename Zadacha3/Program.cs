// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A: ");
int index;
int index_2;
double[] dotA = new double[3];
for (index = 0; index < 3; index++)
{
    dotA[index] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите координаты точки B: ");
double[] dotB = new double[3];
for (index_2 = 0; index_2 < 3; index_2++)
{
    dotB[index_2] = Convert.ToDouble(Console.ReadLine());
}
double distance = Math.Round(Math.Sqrt((Math.Pow((dotA[0] - dotB[0]), 2)) + (Math.Pow((dotA[1] - dotB[1]), 2)) + (Math.Pow((dotA[2] - dotB[2]), 2))), 2);

System.Console.WriteLine(distance);
