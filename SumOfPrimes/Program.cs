using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program tempClass = new Program();
            Console.WriteLine(tempClass.sumOfPrimes(80));
            Console.ReadKey();
        }

        bool isPrime(ulong x)
        {
            for (ulong i = 3; i < x; i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public ulong sumOfPrimes(ulong limit)
        {
            ulong sum = 2;

            if (limit < 2)
            {
                return 0;
            }

            for (ulong i = 3; i < limit; i += 2)
            {
                if (isPrime(i)) sum += i;
            }

            return sum;
        }

    }
}
