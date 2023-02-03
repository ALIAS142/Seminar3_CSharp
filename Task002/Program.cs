// Программа по заданному номеру четверти выдает диапазон возможных координат точек в этой четверти (X,y)

System.Console.WriteLine("Enter section: ");

int Section = int.Parse(Console.ReadLine());

if (Section == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else 
if (Section == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else 
if (Section == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else 
if (Section == 4)
{
    Console.WriteLine("X<>0, Y<0");
}
