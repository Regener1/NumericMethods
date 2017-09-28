using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods.toolbox
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
            int n = matrix.GetLength(0);
            // init
            int[] p = new int[n];
            int[] q = new int[n];

            int imax = 0;
            int jmax = 0;
            int buf = 0;

            for (int i = 0; i < n; i++)
            {
                p[i] = i;
                q[i] = i;
            }

            for (int k = 0; k < 1; k++)
            {

                imax = k;
                jmax = k;

                for (int i = k; i < n; i++)
                {
                    for (int j = k; j < n; j++)
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
        }
        

        public void SLAQ(double[,] matrix)
        {
            

           


                ////normalize
                //for(int j = k + 1; j < n; j++)
                //{
                //    matrix[k, j] = matrix[k, j] / matrix[k, k];
                //}

                //for(int i = k + 1; i < n; i++)
                //{
                //    for (int j = k + 1; j < n; j++)
                //    {
                //        matrix[i, j] -= matrix[i ,]
                //    }
                //}

            
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
