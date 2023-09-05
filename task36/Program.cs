/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
*/
int[] userArray = FillArray(5, 0, 11);
int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i< length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
void PrintArray(int[] arrayForPrint)
{
    Console.Write("[");
    for(int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(",");
    }
    Console.WriteLine("]");
}
void PrintSumOddElements(int[] arrayForSum)
{
    int sumOdd = 0;
    for (int i =0; i < arrayForSum.Length; i += 2)
    {
        sumOdd += arrayForSum[i];
    }
    Console.WriteLine($"суммf элементов, стоящих на нечетных позициях = {sumOdd}");
}
PrintArray(userArray);
PrintSumOddElements(userArray);