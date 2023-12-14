using System;

class Program
{
    static void Main()
    {
        int mod = 23;

        Console.WriteLine("Елiптична крива: y^2 = (x^3 + x + 1) mod 23");

        for (int x = 0; x < mod; x++)
        {
            int ySquared = (int)((Math.Pow(x, 3) + x + 1) % mod);

            int y = FindSquareRootModulo(ySquared, mod);

            if (y != -1)
            {
                Console.WriteLine($"Точка ({x}, {y}) на елiптичнiй кривi.");
            }
        }
    }

    static int FindSquareRootModulo(int a, int p)
    {
        for (int x = 0; x < p; x++)
        {
            if ((x * x) % p == a)
            {
                return x;
            }
        }

        return -1;
    }
}
