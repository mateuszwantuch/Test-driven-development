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


        //  Public : Determine if the given number is a prime number.
        //
        //  x − The number to be checked.
        //
        //  Examples
        //
        //  isPrime(6)
        //  => false
        //
        //  isPrime(7)
        //  => true
        //
        //  Returns true if the given number is prime, else returns false

        bool isPrime(ulong x)
        {
            for (ulong i = 3; i < x; i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        //  Public : Compute sum of the prime numbers below the given limit.
        //
        //  limit - Limit below which sum is being computed.
        //
        //  Examples
        //
        //  sumOfPrimes (20)
        //  => 77
        //
        //  If the given number is less than 2 returns 0,else returns sum of the prime numbers


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
