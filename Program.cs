using System;

class Program
{
    static void Main()
    {
        int rows = 2;
        int count = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= count; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(count + " ");
                }
            }
            count++;
        }

        Console.WriteLine();
    }
}