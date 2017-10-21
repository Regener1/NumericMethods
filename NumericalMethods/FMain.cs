using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumericalMethodsLibrary;

namespace NumericalMethods
{
    public partial class FMain : Form
    {
        private Logic logic = new Logic();

        private MatrixContainer mOriginal = null;
        
        double[,] testMatrix =
        {
            { 2,4,-4,6 },
            { 1,4,2,1 },
            { 3,8,1,1 },
            { 2,5,0,5 }
        };

        
        public FMain()
        {
            InitializeComponent();
        }



        private void btnOpenInputForm_Click(object sender, EventArgs e)
        {
            FInput fInput = new FInput();
            if (DialogResult.OK == fInput.ShowDialog())
            {
                mOriginal = new MatrixContainer();
                mOriginal.baseMatrix = (double[,])fInput.GetMatrix().Clone();
                mOriginal.matrix = fInput.GetMatrix();
                mOriginal.vecX = fInput.GetXVector();
                mOriginal.p = new int[mOriginal.matrix.GetLength(0)];
                mOriginal.q = new int[mOriginal.matrix.GetLength(0)];

                rtbOutput.Text += logic.MatrixToString(mOriginal.matrix, "Исходная матрица");
                rtbOutput.Text += logic.MatrixToString(mOriginal.vecX, "Исходный вектор X");
            }

            //mOriginal = new MatrixContainer();
            //mOriginal.baseMatrix = (double[,])testMatrix.Clone();
            //mOriginal.matrix = testMatrix;
            //mOriginal.vecX = new double[] { 1, 2, 3, 4 };
            //mOriginal.p = new int[testMatrix.GetLength(0)];
            //mOriginal.q = new int[testMatrix.GetLength(0)];


            //rtbOutput.Text += logic.MatrixToString(mOriginal.matrix, "Исходная матрица");
            //rtbOutput.Text += logic.MatrixToString(mOriginal.vecX, "Исходный вектор X");
        }

        private void btnFactorization_Click(object sender, EventArgs e)
        {
            if(mOriginal == null)
            {
                MessageBox.Show("Нет изначальной матрицы");
                return;
            }
            logic.Factorization(mOriginal);
            rtbOutput.Text += logic.MatrixToString(mOriginal.matrix, 
                mOriginal.p, mOriginal.q, "UL разложение");
        }

        private void btnSLAQ_Click(object sender, EventArgs e)
        {
            if (mOriginal == null)
            {
                MessageBox.Show("Нет изначальной матрицы");
                return;
            }
            logic.SLAQ(mOriginal);
            rtbOutput.Text += logic.MatrixToString(mOriginal.vecX,
                mOriginal.p, mOriginal.q, "Решение СЛАУ: расчетный вектор X");
        }
    }
}
