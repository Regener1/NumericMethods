using NumericalMethods.toolbox;
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
    public partial class Form1 : Form
    {
        double[,] testMatrix =
        {
            { 2,4,-4,6 },
            { 1,4,2,1 },
            { 3,8,1,1 },
            { 2,5,0,5 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (!int.TryParse(textBoxMatrSize.Text, out n))
            {
                MessageBox.Show("Invalid value");
                return;
            }

            MatrixMaths matMath = new MatrixMaths();
            double[,] matrix = matMath.CreateMatrix(n);
            matMath.Factorization(testMatrix);

            this.dataGridMatrix.ColumnCount = n;

            for (int r = 0; r < n; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridMatrix);

                for (int c = 0; c < n; c++)
                {
                    row.Cells[c].Value = matrix[r, c];
                }

                this.dataGridMatrix.Rows.Add(row);
            }
        }
    }
}
