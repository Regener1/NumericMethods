using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMethods.toolbox
{
    public class MatrixMaths
    {
        private void ConsolePrint(double[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0:0.####} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        public double NormalDistribNum(Random rnd)
        {
            double num = rnd.NextDouble();

            if (num > 0.5)
            {
                return num = num * 100;
            }
            else if (num < 0.5)
            {
                return num = (100 - num * 100) * -1;
            }
            else
            {
                return num = 0;
            }
        }

        public double[,] CreateMatrix(int n)
        {
            Random rnd = new Random();
            double[,] matrix = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = NormalDistribNum(rnd);
                }
            }

            ConsolePrint(matrix);

            return matrix;

        }

        public void Factorization(double[,] matrix)
        {

        }

        public void SLAQ(double[,] matrix)
        {

        }

        public double Determinant(double[,] matrix)
        {

            return 0.0;
        }

        public double[,] InverceMatrix1(double[,] matrix)
        {
            return null; 
        }

        public double[,] InverceMatrix2(double[,] matrix)
        {
            return null;
        }
    }
}
