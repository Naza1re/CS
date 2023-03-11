class Program
{

    public static void Main(String[] args)
    {
        double A, B, C;

        Console.WriteLine("Введите число A : ");
        A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число B : ");
        B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число C : ");
        C = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int k = 0;
        int n = 0;

        while (A >= C)
        {
            A -= C;
            k++;
        }

        while (B >= C)
        {
            B -= C;
            n++;
        }


        for(int i = 0; i < n;i++)
        {
            count += n;


        }
        Console.WriteLine("Можно поместить квдрат со стороной " + C + " : " + count + " раз ");








    }



}