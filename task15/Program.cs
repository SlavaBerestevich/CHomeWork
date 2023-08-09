/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 1)
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("не выходной");
}
else if (weekday == 2)
{
    Console.WriteLine("Вторник");
    Console.WriteLine("не выходной");
}
else if (weekday == 3)
{
    Console.WriteLine("Среда");
    Console.WriteLine("не выходной");
}
else if (weekday == 4)
{
    Console.WriteLine("Четверг");
    Console.WriteLine("не выходной");
}
else if (weekday == 5)
{
    Console.WriteLine("Пятница");
    Console.WriteLine("не выходной, но уже скоро");
}
else if (weekday == 6)
{
    Console.WriteLine("Суббота");
    Console.WriteLine("выходной");
}
else if (weekday == 7)
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("выходной");
}