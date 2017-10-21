using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethodsLibrary
{
    public class MatrixMaths
    {
        private void Pivoting(int k, double[,] a, ref int[] p, ref int[] q)
        {
            int imax = 0;
            int jmax = 0;
            int buf = 0;

            imax = k;
            jmax = k;

            for (int i = k; i >= 0; i--)
            {
                for (int j = k; j >= 0; j--)
                {
                    if (Math.Abs(a[p[i], q[j]]) > Math.Abs(a[p[imax], q[jmax]]))
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

        public double[,] Factorization(double[,] a, ref int[] p, ref int[] q)
        {
            int n = a.GetLength(0);
            
            for (int i = 0; i < n; i++)
            {
                p[i] = i;
                q[i] = i;
            }

            for (int k = n - 1; k >= 0; k--)
            {
                
                //Pivoting(k, a, ref p, ref q);

                for (int i = k - 1; i >= 0; i--)
                {
                    a[p[i], q[k]] /= a[p[k], q[k]];
                    for (int j = k - 1; j >= 0; j--)
                    {
                        a[p[i], q[j]] -= a[p[i], q[k]] * a[p[k], q[j]];
                    }
                }

            }


            ////console output
            //for(int i =0; i < p.Length; i++)
            //{
            //    for(int j = 0; j < q.Length; j++)
            //    {
            //        Console.Write("{0:0.####} ", a[p[i], q[j]]);
            //    }
            //    Console.WriteLine();
            //}

            return a;
        }
        
        public double[] FindVecB(double[,] a, double[] x)
        {
            int n = a.GetLength(0);
            double sum;
            double[] b = new double[n];

            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j] * x[j];
                }
                b[i] = sum;
            }

            return b;
        }


        public double[] SLAQ(double[,] ul, int[] p, int[] q, double[] b)
        {
            int n = ul.GetLength(0);
            double sum;

            /*
             *  a*x1 + a*x2 = b
             *         a*x2 = b
             * 
             * x2 = b / a
             * x1 = b - a*x2 / a
             */

            // search Uw = Pb => w
            for(int i = n - 1; i >= 0; i--)
            {
                sum = 0;
                for(int j = n - 1; j > i; j--)
                {
                    sum += ul[p[i], q[j]] * b[p[j]];
                }
                b[p[i]] -= sum; 
            }

            /*
             * a*x1        = w
             * a*x1 + a*x2 = w
             * 
             * x1 = w / a
             * x2 = w - a*x1 / a
             * 
             * 
             */

            //search Ly = w => y
            for(int i = 0; i < n; i++)
            {
                sum = 0;
                for(int j = 0; j < i; j++)
                {
                    sum += ul[p[i], q[j]] * b[p[j]];
                }
                b[p[i]] = (b[p[i]] - sum) / ul[p[i], q[i]];
            }

            double[] resX = new double[n];
            for (int i = 0; i < n; i++)
            {
                resX[i] = b[q[p[i]]];
            }

            //search x = Qy
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0:0.####} ", b[q[p[i]]]);
            }

            return resX;

            
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
