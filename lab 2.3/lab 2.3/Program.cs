


class Program
{

    public static void Main(String[] args)
    {
        double xmin, xmax, dx, a, b, c,f;
        do
        {

            Console.WriteLine("Введите перменную Xmin");
            xmin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите перменную Xmax");
            xmax = Convert.ToDouble(Console.ReadLine());
            if (xmax < xmin)
            {
                Console.WriteLine("Xmax не может быть меньше Xmin");
               
            }

            Console.WriteLine("Введите перменную Dx");
            dx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите перменную a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите перменную b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите перменную c");
            c = Convert.ToDouble(Console.ReadLine());
        } while (xmax < xmin|| c==0) ;
        Console.WriteLine("____________________________________________");



        for(double x = xmin;x<=xmax;x = x+dx)
        {
            if (x - c == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                break;
            }
            if (x - c == 0)
            {
                
            }
            if (x < 0 && b != 0)
            {
                f = a * Math.Pow(x, 2) + b;
            }
           
            else
                if (x > 0 && b == 0)
            {

                f = (x - a) / (x - c);

            }
            else
                f = x / c;


            Console.WriteLine( f + "       " + x);
        }
        Console.WriteLine("____________________________________________");













    }

}