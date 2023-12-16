using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.TaskReview.V10.Lib;

namespace Tyuiu.IvanovJD.Sprint6.TaskReview.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonRezult_IJD_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBoxWeightMtrx_IJD.Text);
            int column = Convert.ToInt32(textBoxLengMtrx_IJD.Text);

            int startRnd = Convert.ToInt32(textBoxStartRnd_IJD.Text);
            int stopRnd = Convert.ToInt32(textBoxStopRnd_IJD.Text);

            int[,] array = new int[row, column];

            Random rnd = new Random();

            dataGridViewMatrix_IJD.ColumnCount = column;
            dataGridViewMatrix_IJD.RowCount = row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j > 0 && ((j + 1) % 2 == 0))
                    {
                        int x = array[i, j - 1];
                        array[i, j] = (int)Math.Pow(x, 3);
                    }

                    else
                    {
                        array[i, j] = rnd.Next(startRnd, stopRnd);
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewMatrix_IJD.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            int c = Convert.ToInt32(textBoxSelectColumn_IJD.Text);
            int k = Convert.ToInt32(textBoxStartNumColumn_IJD.Text);
            int l = Convert.ToInt32(textBoxStopColumn_IJD.Text);
            int result = ds.GetMatrix(array, c, k, l);
            textBoxResult_IJD.Text = Convert.ToString(result);
        }
    }
}
