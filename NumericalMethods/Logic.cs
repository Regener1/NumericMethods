using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericalMethodsLibrary;

namespace NumericalMethods
{
    public class Logic
    {
        private MatrixMaths matMath = new MatrixMaths();
        

        public void Factorization(MatrixContainer matrix)
        {
            matrix.matrix = matMath.Factorization(matrix.matrix, ref matrix.p, ref matrix.q);
        }

        public void SLAQ(MatrixContainer matrix)
        {
            double[] b = matMath.FindVecB(matrix.baseMatrix, matrix.vecX);

            matrix.vecX = matMath.SLAQ(matrix.matrix, matrix.p, matrix.q, b);
        }

        public string MatrixToString(double[,] matrix, int[] p, int[] q, string name)
        {
            int n = matrix.GetLength(0);
            StringBuilder res = new StringBuilder();

            res.Append(name);
            res.Append(Environment.NewLine);

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    res.Append(matrix[p[i], q[j]].ToString("F4"));
                    res.Append("\t");
                    
                }
                res.Append(Environment.NewLine);
            }



            res.Append(Environment.NewLine);

            return res.ToString();
        }

        public string MatrixToString(double[,] matrix, string name)
        {
            int n = matrix.GetLength(0);
            StringBuilder res = new StringBuilder();

            res.Append(name);
            res.Append(Environment.NewLine);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res.Append(matrix[i, j].ToString("F4"));
                    res.Append("\t");

                }
                res.Append(Environment.NewLine);
            }



            res.Append(Environment.NewLine);

            return res.ToString();
        }

        public string MatrixToString(double[] matrix, string name)
        {
            int n = matrix.Length;
            StringBuilder res = new StringBuilder();

            res.Append(name);
            res.Append(Environment.NewLine);

            for (int i = 0; i < n; i++)
            {
                res.Append(matrix[i].ToString("F4"));
                res.Append("\t");
            }

            res.Append(Environment.NewLine);
            res.Append(Environment.NewLine);

            return res.ToString();
        }

        public string MatrixToString(double[] matrix, int[] p, int[] q, string name)
        {
            int n = matrix.Length;
            StringBuilder res = new StringBuilder();

            res.Append(name);
            res.Append(Environment.NewLine);

            for (int i = 0; i < n; i++)
            {
                res.Append(matrix[q[p[i]]].ToString("F4"));
                res.Append("\t");
            }

            res.Append(Environment.NewLine);
            res.Append(Environment.NewLine);

            return res.ToString();
        }
    }
}
