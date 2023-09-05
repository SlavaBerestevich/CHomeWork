/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/
int[] FillArray()
{
    System.Console.Write("введите размер массива");
    int length = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random(). Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    }
    void PrintEvenCountInArray(int[] array)
    {
        int count = 0;
        foreach (int item in array)
        {
            if (item%2 == 0) count++;
        }
        System.Console.WriteLine($"{count} четных чисел в массиве");
    }

    int[] userArray = FillArray();

    PrintArray(userArray);
    PrintEvenCountInArray(userArray);