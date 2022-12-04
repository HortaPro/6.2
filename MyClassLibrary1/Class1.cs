using System;

namespace MyClassLibrary1
{
    public class Class1
    {
        static public void Lib()
        {
            int[,] mas = new int[3, 6];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
