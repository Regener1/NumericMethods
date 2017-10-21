using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericalMethods
{
    public partial class FInput : Form
    {
        private Random rnd = new Random();
        private double[,] resMatrix = null;
        private double[] resX = null;

        public FInput()
        {
            InitializeComponent();
        }

        private double NormalDistribNum(Random rnd)
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

        private double[,] CreateRandomMatrix(int n)
        {
            
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = NormalDistribNum(rnd);
                }
            }

            return matrix;

        }

        private double[] CreateRandomVector(int n)
        {
            double[] vector = new double[n];
            for(int i = 0; i < n; i++)
            {
                vector[i] = NormalDistribNum(rnd);
            }

            return vector;
        }

        private void OutputToDataGrid(double[,] matrix, DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            dataGrid.RowCount = matrix.GetLength(0);
            dataGrid.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void OutputToDataGrid(double[] vector, DataGridView dataGrid)
        {
            if (vector == null)
            {
                return;
            }

            dataGrid.Rows.Clear();

            dataGrid.RowCount = vector.GetLength(0);
            dataGrid.ColumnCount = 1;

            for (int i = 0; i < vector.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = vector[i];
                }
            }
        }

        public double[,] GetMatrix()
        {
            return resMatrix;
        }

        public double[] GetXVector()
        {
            return resX;
        }

        private void btnFromText_Click(object sender, EventArgs e)
        {
            string s = tbText.Text;
            string[] rows = s.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] colomns = null;

            string[] vector = tbTestVector.Text.Split(';');

            double number;

            resMatrix = new double[rows.Length, rows.Length];
            resX = new double[rows.Length];

            if(rows.Length != vector.Length)
            {
                MessageBox.Show("Wrong matrix size", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resMatrix = null;
                resX = null;
                return;
            }

            for(int i = 0; i < vector.Length; i++)
            {
                if (double.TryParse(vector[i], out number))
                {
                    resX[i] = number;
                }
                else
                {
                    MessageBox.Show("Error convert number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resX = null;
                    resMatrix = null;
                    return;
                }
            }

            for (int i = 0; i < rows.Length; i++)
            {
                colomns = rows[i].Split(';');

                if (colomns.Length != rows.Length)
                {
                    MessageBox.Show("Wrong matrix size", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resMatrix = null;
                    return;
                }
                
                for (int j = 0; j < colomns.Length; j++)
                {
                
                    if(double.TryParse(colomns[j], out number))
                    {
                        resMatrix[i, j] = number;
                    }
                    else
                    {
                        MessageBox.Show("Error convert number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resMatrix = null;
                        return;
                    }
                }
            }

            OutputToDataGrid(resMatrix, dgvPreviewMatrix);
            OutputToDataGrid(resX, dgTestVectorPreview);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            resMatrix = CreateRandomMatrix((int)nudSize.Value);
            resX = CreateRandomVector((int)nudSize.Value);
            OutputToDataGrid(resMatrix, dgvPreviewMatrix);
            OutputToDataGrid(resX, dgTestVectorPreview);
        }

        private void btnBadMatrix_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
