using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NumMethods.toolbox;

namespace NumMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        MatrixMaths matMath = new MatrixMaths();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGenerateMatrix_Click(object sender, RoutedEventArgs e)
        {

            int n = 0;
            if (!int.TryParse(textBoxMatrixSize.Text, out n))
            {
                MessageBox.Show("Invalid value");
            }

            double[,] matrix = matMath.CreateMatrix(n);

            DataTable dt = new DataTable();

            for (int i = 0; i < n; i++)
            {
                dt.Columns.Add("x" + (i + 1));
            }

            DataRow dr = dt.NewRow();

            for (int i = 0; i < n; i++)
            {
                dr.ItemArray = ;
            }

            dt.Rows.Add()
            
        }
    }
}
