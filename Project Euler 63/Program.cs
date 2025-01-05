using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net.Http.Headers;
using System.Data.SqlTypes;
namespace Project_Euler_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger count = 0;
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    BigInteger number = BigInteger.Pow(i, j);
                    if (CheckingTheNumbers(number, j) == true)
                    {
                        Console.WriteLine(number + " = " + i + "^" + j);
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        static bool CheckingTheNumbers(BigInteger number, BigInteger power)
        {
            BigInteger NumberLength = number.ToString().Length;
            if (NumberLength == power)
            {
                return true;
            }
            return false;
        }
    }
}
