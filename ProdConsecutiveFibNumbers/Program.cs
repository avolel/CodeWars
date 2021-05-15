using System;

namespace ProdConsecutiveFibNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Fib(5)}");
        }

        public static ulong[] productFib(ulong prod)
        {
            ulong[] output = null;
            for (ulong i = 0; i <= prod; i++)
            {
                ulong index = Fib(i) * Fib(i + 1);

                if (index == prod)
                {
                    output = new ulong[] { Fib(i), Fib(i + 1), 1 };
                    break;
                }
                else if (index > prod)
                {
                    output = new ulong[] { Fib(i), Fib(i + 1), 0 };
                    break;
                }
            }
            return output;
        }

        private static ulong Fib(ulong n)
        {
            ulong[] f = new ulong[n + 2];
            ulong i;

            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}
