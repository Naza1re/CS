using System;

namespace std;

class Program
{

    public static void Main(String[] args)
    {
        Console.WriteLine("Введите число для определния его знака");


        double a = Convert.ToInt32(Console.ReadLine());
        bool b = false;

        if (a > 0)
        {
            b = true;
            Console.WriteLine(b+ "Данное число больше нуля");
        }
        else
        {
            Console.WriteLine(b+ "Даное чилсо меньше нуля");


        }



    }
}