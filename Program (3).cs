/* 

!! y = k1 * x + b1
y = k2 * x + b2

k1*x+b1=k2*x+b2
k1*x=k2*x+b2-b1
k1*x-k2*x=b2-b1
x(k1-k2)=b2-b1
!! x=(b2-b1)/(k1-k2)
 */


void CrossLines(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Its one Line");
    else if (k1 == k2)
        Console.WriteLine("Its no cross Line");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        Console.WriteLine("Coordinate x =  "+x);
        double y = k1 * x + b1;
        Console.WriteLine("Coordinate x =  "+y);
    }
}
Console.WriteLine("Input b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToDouble(Console.ReadLine());

CrossLines(b1, k1, b2, k2);