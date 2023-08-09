/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("это не трехзначное число, попробуйте еще раз");
    return;
}
if (number >= 1000)
{
     Console.WriteLine("это не трехзначное число, попробуйте еще раз");
    return;
}
Console.WriteLine($"число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"вторая цифра {secondRank}");