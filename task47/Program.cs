/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
double[,] Fill2DArray()
{
    Console.Write("введите количество столбцов");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количетсво строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[cols, rows];
    Console.Write("введите минимальное значение");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максимальное значение");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i,j] = new Random().NextDouble() * (maxValue - minValue) + (minValue);

        } 
        
    }
    return array;
}
void Print2DArray(double[,] arrayForPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayForPrint[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}
Print2DArray(Fill2DArray());