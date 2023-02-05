// Программа принимает число N и выдает таблицу квадратов этого числа.

System.Console.WriteLine("Enter number:  ");
int numN = int.Parse(Console.ReadLine());

int numK = 1;

while (numK <= numN)
{
     System.Console.Write(Convert.ToInt32(Math.Pow(numK, 2)));
    
     numK = numK + 1;
}
  






