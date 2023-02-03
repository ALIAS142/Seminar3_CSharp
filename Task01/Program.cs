// Программа принимает на вход координаты точки (X, Y), где
// X != 0 И Y !=0. На выходе: номер четвери плоскости,  в которой находится эта точка.

System.Console.Write("Enter number X: ");
int numX = int.Parse(Console.ReadLine());

System.Console.Write("Enter number Y: ");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 & numY > 0)
{
    Console.WriteLine("1 section");
}
else 
if (numX < 0 & numY > 0)
{
    Console.WriteLine("2 section");
}
else 
if (numX < 0 & numY < 0)
{
    Console.WriteLine("3 section");
}
else 
if (numX > 0 & numY < 0)
{
    Console.WriteLine("4 section");
}
