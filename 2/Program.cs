//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
const int b1 = 0;
const int k1 = 1;
const int b2 = 2;
const int k2 = 3;

void UserInput(double[] koeff, string msg)
{
    System.Console.WriteLine($"введите коэффициенты b1, k1, b2, k2");
    for (int i = 0; i <= koeff.Length - 1; i++)
    {
        koeff[i] = Convert.ToDouble(Console.ReadLine());
    }
}
double CheckPointX(double[] koeff)
{
    double x = (koeff[b2] - koeff[b1]) / (koeff[k1] - koeff[k2]);
    return x;
}
double CheckPointY(double [] koeff)
{
    double x = CheckPointX(koeff);
    double y = koeff[k1] * x + koeff[b1];
    return y;
}

double [] koeff = new double[4];

UserInput(koeff, "введите коэффициенты");
double resultX = CheckPointX(koeff);
double resultY = CheckPointY(koeff);
System.Console.WriteLine($"точка пересечения двух прямых: {resultX}, {resultY}");