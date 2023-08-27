/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
Console.WriteLine("введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 0) number = number * -1;
for (int i = 1; i < number +1; i++)
{
   result = i * i *i;
   Console.WriteLine(result);
}   