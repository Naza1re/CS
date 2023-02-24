using System;

namespace std;
class Program
{

    public static void Main(String[] args)
    {
        Console.WriteLine("Введите число a");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число б");
        double b = Convert.ToInt32(Console.ReadLine());



        if (a > b)
        {
            Console.WriteLine("Число а больше чилса б");

        }
        else
            Console.WriteLine("Число б больше чилса а");


    }


}
