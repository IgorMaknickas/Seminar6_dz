// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите значение b1= ");
int b1 =int.Parse(Console.ReadLine());
Console.Write("Введите значение k1= ");
int k1 =int.Parse(Console.ReadLine());
Console.Write("Введите значение b2= ");
int b2 =int.Parse(Console.ReadLine());
Console.Write("Введите значение k2= ");
int k2 =int.Parse(Console.ReadLine());

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
   double x = 0;
    double y = 0;
    x = (-(b1-b2) / (k1 - k2));
    y = (k1* x+b1);
    Console.WriteLine($"{x}, {y}"); 
}
IntersectionPoint(b1, k1, b2, k2);
