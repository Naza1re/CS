using System;

namespace std;

class Program
{

    public static void Main(String[] args)
    {
        double x;
        double y;
     
        do
        {
            Console.WriteLine("Есть условие которое надо выполнить, кароче число А длолжно быть больше Б");
            Console.WriteLine("Введите число А");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиет число Б");
            y = Convert.ToInt32(Console.ReadLine());
           

        } while (!(x>= y));
        double g = x / y;
        Console.WriteLine("Поместится " + g + " Раз");

    }

  

}
