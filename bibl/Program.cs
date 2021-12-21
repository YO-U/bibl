using System;
using MyLib;
namespace bibl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3, 6];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mas[i, j] = rnd.Next(-100, 100);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            int res = MyLib.ClassLib.SumNegative(mas);
        }
    }
}
