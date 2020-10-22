using System;

namespace Anna_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 25;
            double[] A = new double[m];
            for(int i=0;i<m;i++)
            {
                A[i] = i+4;
            }
            
            Console.WriteLine("Введите x: " );

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("============================================");
            if (x == 0)
            {
                Console.WriteLine("Изменений в массиве нет!!");

            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    if (A[i]%2==1)
                    {
                        A[i] = A[i] + x;
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    Console.WriteLine(A[i]);
                }
            }
           

        }
    }
}
