/* Напишите программу, которая по номеру четверти, показывает диапазон координат возможных точек в этой четверти (x и y)
*/
Console.WriteLine("введите номер четверти");
int numberCH = Convert.ToInt32(Console.ReadLine());
if (numberCH == 1)
{
    Console.WriteLine("все X > 0, все Y > 0");
}
else if (numberCH == 2)
{
    Console.WriteLine("все X < 0, все Y > 0");
}
else if (numberCH == 3)
{
    Console.WriteLine("все X < 0, все Y < 0");
}
else if (numberCH == 1)
{
    Console.WriteLine("все X > 0, все Y < 0");
}
else 
{
    Console.WriteLine("нет такой четверти");
}


