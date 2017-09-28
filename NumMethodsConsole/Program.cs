using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericalMethods.toolbox;

namespace NumMethodsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] testMatrix =
            {
                { 2,4,-4,6 },
                { 1,4,2,1 },
                { 3,8,1,1 },
                { 2,5,0,5 }
            };

            MatrixMaths mm = new MatrixMaths();
            mm.Factorization(testMatrix);

            Console.ReadKey();
        }
    }
}
