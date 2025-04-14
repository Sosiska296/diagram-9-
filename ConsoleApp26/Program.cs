Console.WriteLine("НАЧАЛО");
Console.WriteLine("ВВОД a,b,c");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.WriteLine("x = любое число"); 
        }
        else
        {
            Console.WriteLine("нет решения"); 
        }
    }
    else
    {
        double x1 = -c / b; 
        Console.WriteLine("x1 = " + x1); 
    }
}
else
{
    double D = b * b - 4 * a * c; 

    if (D > 0)
    {
        double sqrtD = Math.Sqrt(D); 
        double x1 = (-b - sqrtD) / (2 * a); 
        double x2 = (-b + sqrtD) / (2 * a); 
        Console.WriteLine("x1 = " + x1 + ", x2 = " + x2); 
    }
    else
    {
        if (D == 0)
        {
            double x1 = -b / (2 * a); 
            Console.WriteLine("x1 = " + x1); 
        }
        else
        {
            Console.WriteLine("нет решения"); 
        }
    }
}
Console.WriteLine("КОНЕЦ");