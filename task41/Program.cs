/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] InputArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.lenght; i++)
    {
        array[i] = Prompt($"введите {i + 1}-й элемент");
    } 
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.lenght; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Lenght; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int lenght = Prompt("Введите количество элементов >");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");