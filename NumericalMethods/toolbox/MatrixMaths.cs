using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods.toolbox
{
    public class MatrixMaths
    {

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

            return matrix;

        }

        public double[,] Factorization(double[,] matrix, ref int[] p, ref int[] q)
        {
            int n = matrix.GetLength(0);
            // init
            p = new int[n];
            q = new int[n];

            int imax = 0;
            int jmax = 0;
            int buf = 0;

            for (int i = 0; i < n; i++)
            {
                p[i] = i;
                q[i] = i;
            }

            for (int k = n - 1; k >= 0; k--)
            {

                imax = k;
                jmax = k;

                for (int i = k; i >= 0; i--)
                {
                    for (int j = k; j >= 0; j--)
                    {
                        if (Math.Abs(matrix[p[i], q[j]]) > Math.Abs(matrix[p[imax], q[jmax]]))
                        {
                            imax = i;
                            jmax = j;
                        }
                    }
                }


                // Swap
                if (imax != k)
                {
                    buf = p[k];
                    p[k] = p[imax];
                    p[imax] = buf;
                }
                if (jmax != k)
                {
                    buf = q[k];
                    q[k] = q[jmax];
                    q[jmax] = buf;
                }

                for (int i = k - 1; i >= 0; i--)
                {
                    matrix[p[i], q[k]] /= matrix[p[k], q[k]];
                    for (int j = k - 1; j >= 0; j--)
                    {
                        matrix[p[i], q[j]] -= matrix[p[i], q[k]] * matrix[p[k], q[j]];
                    }
                }

            }




            //console output
            for(int i =0; i < p.Length; i++)
            {
                for(int j = 0; j < q.Length; j++)
                {
                    Console.Write("{0:0.####} ", matrix[p[i], q[j]]);
                }
                Console.WriteLine();
            }

            return matrix;
        }
        

        public void SLAQ(double[,] matrix, int[] p, int[] q, double[] x)
        {
            int n = matrix.GetLength(0);

            double[] w = new double[n];

            //search w=Lx => w 
            double sum;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for(int j = 0; j <= i; j++)
                {
                    sum += matrix[p[i], q[j]] * x[q[j]];
                }
                w[i] = sum;
            }

            //search Uw = b => b
            double[] b = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                sum = 0;
                for (int j = i; j > 0; j--)
                {
                    sum += matrix[p[i], q[j]] * w[j];
                }
                b[i] = sum + w[0];
            }

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
