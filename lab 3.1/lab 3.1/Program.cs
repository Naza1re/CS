using System.Diagnostics;

class Program
{
    public static void Main(String[] args)
    {
        String swet;
        int degree = 0;
        Console.WriteLine("Введите сторону света : (N,S,E,W)");
        swet = Console.ReadLine();
        

        switch (swet)
        {

            case ("N"):
                degree = 0;
                Console.WriteLine("Ваш градус : " + degree);
                break;
            case ("S"):
                degree = 180;
                Console.WriteLine("Ваш градус : " + degree);

                break;
            case ("E"):
                degree = 90;
                Console.WriteLine("Ваш градус : " + degree);

                break;
            case ("W"):
                degree = 270;
                Console.WriteLine("Ваш градус : " + degree);

                break;

        }
        Console.WriteLine("Введите число для поворота (1-поворот на 90  2 - поворот на 180  -1 - поворото на -90)");
        int povorot = int.Parse(Console.ReadLine());
        int degree1=0;


        switch (povorot)
        {
            case 1:
                degree1 = degree + 90 ;
               
             
                break;
            case 2:
                degree1 = degree + 180;

                break;
            case -1:
                degree1 = degree - 90;
                if(degree1 < 0) 
                { degree1 = 270; }
                break;

        }
    
       


        if (degree1 == 0||degree1==360)
        {
            swet = "Вы смотрите на север";
        }
        else
            if (degree1 == 90||degree1== 450)
        {
            swet = "Вы смотрите на восток";
        }
        else
            if (degree1 == 180)
        {
            swet = "Вы смотрите на юг";
        }
        else

        {

            swet = "Вы смотрите на запад";
        }

        Console.WriteLine(swet);


    }
}




