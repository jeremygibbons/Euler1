using System;
using System.Text;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            uint.TryParse(args[0], out n);

            long s3 = 3 * gauss((n - 1) / 3);
            long s5 = 5 * gauss((n - 1) / 5);
            long s15 = 15 * gauss((n - 1) / 15);
            Console.WriteLine(s3 + s5 - s15);
            Console.ReadLine();
        }

        static long gauss(uint n)
        {
            return n * (n + 1) / 2;
        }
    }
}
