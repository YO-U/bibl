using System;

namespace MyLib
{
    public class ClassLib
    {
        public static int SumNegative(int[,] mas)
        {

            
            int max = mas[0, 0];
            int min = mas[0, 0];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(); 
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mas[i, j] + " ");
                    if (mas[i, j] > max)
                        max = mas[i, j];

                    if (mas[i, j] < min)
                        min = mas[i, j];                                      
                }
            }  
            int S = 0;
            S += max + min;
            Console.WriteLine();
            Console.WriteLine("Макс {0}",max);
            Console.WriteLine("Мин {0}",min);
                    Console.WriteLine("Сумма {0}",S);
            return max;
            return min;

        }
    }
}