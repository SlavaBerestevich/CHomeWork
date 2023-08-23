/* Напишите программу, которая на вход принимает координаты точки (X и Y), причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, 
в которой находится эта точка
*/
Console.WriteLine("введите X и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());
if (userX > 0 && userY > 0)
{
    Console.WriteLine($" точка {userX} : {userY} находится в первой четверти ");
}
else if (userX < 0 && userY > 0)
{
    Console.WriteLine($" точка {userX} : {userY} находится во второй четверти ");
}
else if (userX < 0 && userY < 0)
{
    Console.WriteLine($" точка {userX} : {userY} находится в третьей четверти ");
}    
else 
{
    Console.WriteLine($" точка {userX} : {userY} находится в четвертой четверти ");
}