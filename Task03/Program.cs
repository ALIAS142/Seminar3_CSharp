// Программа принимает координаты двух точек и находит расстояние междк ними в 2D -плоскости.

System.Console.Write("Enter Point's A coordinats X:  ");
double AX = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's A coordinats Y:  ");
double AY = double.Parse(Console.ReadLine());


System.Console.Write("Enter Point's B coordinats X:  ");

double BX = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's B coordinats Y:  ");
double BY = double.Parse(Console.ReadLine());

double C1 = AY - BY;
double C2 = AX - BX;

double result = (C1 * C1) + (C2 * C2);
double result2 = Math.Sqrt(result);

System.Console.WriteLine(result2);