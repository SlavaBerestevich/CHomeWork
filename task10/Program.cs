/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number = number / 10;
}
int numberThree = number % 10;

if (number > 100)
{
    Console.WriteLine(numberThree);
}
else
{
    Console.WriteLine("третьей цифры нет");
}