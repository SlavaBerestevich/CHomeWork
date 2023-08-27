/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
Console.WriteLine("введите координаты");
int xA = 7, yA = -5, zA = 0;
int xB = 1, yB = -1, zB = 9;
double diffAB = Math.Sqrt((xB - xA) * (xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
Console.Write(Math.Round(diffAB,2));