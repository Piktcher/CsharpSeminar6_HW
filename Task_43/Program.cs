// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindIntersectionPointHorizontalAxis (double k1, double b1, double k2, double b2)
{
    double horizontalAxis = (b2 - b1) / (k1 - k2);
    return horizontalAxis;
}

double FindIntersectionPointVerticalAxis (double k1, double b1, double horizontalAxis)
{
    double verticalAxis = k1 * horizontalAxis + b1;
    return verticalAxis;
}

Console.WriteLine("Введите необходимые коэффициенты для 2-ух линейных уравнений");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double resultX = FindIntersectionPointHorizontalAxis(k1, b1, k2, b2);
double resultY = FindIntersectionPointVerticalAxis(k1, b1, FindIntersectionPointHorizontalAxis(k1, b1, k2, b2));

Console.WriteLine($"Точка пересечения двух уравнений на графике - ({resultX};{resultY})");