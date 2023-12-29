using System;

class Program
{
    static void Main()
    {
        int mod = 23;

        Console.WriteLine("Елiптична крива: y^2 = (x^3 + x + 1) mod 23");

        for (int x = 0; x < mod; x++)
        {
            int ySquared = ModPow((int)(Math.Pow(x, 3) + x + 1), 2, mod);

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
            if (ModPow(x, 2, p) == a)
            {
                return x;
            }
        }

        return -1;
    }

    static int ModPow(int baseNum, int exponent, int modulus)
    {
        int result = 1;
        baseNum = baseNum % modulus;

        while (exponent > 0)
        {
            if (exponent % 2 == 1)
            {
                result = (result * baseNum) % modulus;
            }

            exponent = exponent >> 1;
            baseNum = (baseNum * baseNum) % modulus;
        }

        return result;
    }
}
