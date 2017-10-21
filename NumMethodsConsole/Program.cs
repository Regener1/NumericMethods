using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericalMethodsLibrary;

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

            double[,] testMatrix1 =
            {
                { 2,4,-4,6 },
                { 1,4,2,1 },
                { 3,8,1,1 },
                { 2,5,0,5 }
            };

            MatrixMaths mm = new MatrixMaths();
            int[] p = new int[4];
            int[] q = new int[4];
            double[] x = { 1, 2, 3, 4 };
            double[,] matrix = mm.Factorization(testMatrix,ref p,ref q);
            double[] b = mm.FindVecB(testMatrix1, x);
            mm.SLAQ(matrix, p, q, b);


            Console.ReadKey();
        }
    }
}
