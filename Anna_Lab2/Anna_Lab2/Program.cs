using System;

namespace Anna_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, h_x = 0.5, a = 2, h_a = 1,y=0;
            while(x<=8)
            {
               // y = a^2+x
               // y = a^2
               // y =  a^2 - x

                a = 2;
                while (a<=10)
                {
                    if(a>x)
                    {
                        y = Math.Pow(a, 2) + x;
                        Console.WriteLine("y = a^2+x = " + y);
                    }
                    if (a == x)
                    {
                        y = Math.Pow(a, 2);
                        Console.WriteLine("y = a^2 = "+y);
                    }
                    if (a < x)
                    {
                        y = Math.Pow(a, 2) - x;
                        Console.WriteLine("y =  a^2 - x = "+y);
                    }
                    //Console.WriteLine("y = "+ y);
                    a += h_a;
                   
                }
                Console.WriteLine("===============================================");
                //a = 2;
                x += h_x;
            }

        }
    }
}
