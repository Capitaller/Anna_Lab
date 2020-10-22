using System;


namespace Anna_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
            double[,] A = new double[size, size];
            Random rnd = new Random();
            double maxElement = A[0, 0];
            for (int i =0;i<size;i++)
            {
                for (int j = 0; j < size; j++)
                {
                    A[i,j] = rnd.Next(-10, 10);
                    Console.Write("{0} ", A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                  if(i<j&&A[i,j]<0)
                    {
                        A[i, j] = 0;
                    }
                   

                }
                
            }
            Console.WriteLine("==============================");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i + j > size - 1)
                    {
                        if (maxElement < A[i, j])
                        {
                            maxElement = A[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("==============================");
            Console.WriteLine("Максимальный элемент: " + maxElement);
            Console.WriteLine("=====================================");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

        }
    }
}
