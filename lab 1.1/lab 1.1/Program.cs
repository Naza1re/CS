using System;

namespace std;

class Program
{

    public static void Main(String[] args)
    {
        double a;


        Console.WriteLine("Введите сторону квадрата");

        a = Convert.ToInt32(Console.ReadLine());

        double b = a * a;

        Console.WriteLine("Площадь квадрата равна : " + b);

        double c = a * 4;

        Console.WriteLine("Периметр квадрата равен :" + c);
    }
}
       


