using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Matrix : Form
    {
        public double w1, w2, w3, w4, w5;
        public Matrix()
        {
            InitializeComponent();
        }

        private void матрица_весовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.матрица_весовBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.saharny_diabetDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saharny_diabetDataSet1.Матрица_весов' table. You can move, or remove it, as needed.
            this.матрица_весовTableAdapter1.Fill(this.saharny_diabetDataSet1.Матрица_весов);
            dgv1.Rows[0].HeaderCell.Value = "Мочеиспускание";
            dgv1.Rows[1].HeaderCell.Value = "Жажда";
            dgv1.Rows[2].HeaderCell.Value = "Аппетит";
            dgv1.Rows[3].HeaderCell.Value = "Сонливость";
            dgv1.Rows[4].HeaderCell.Value = "Зрение";
            dgv1.Rows[5].HeaderCell.Value = "Веса критериев";
        }

        private void RaschetVesov_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(dgv1.Rows[0].Cells[0].Value) +
               Convert.ToDouble(dgv1.Rows[0].Cells[1].Value) +
               Convert.ToDouble(dgv1.Rows[0].Cells[2].Value) +
               Convert.ToDouble(dgv1.Rows[0].Cells[3].Value) +
               Convert.ToDouble(dgv1.Rows[0].Cells[4].Value);
            double a2 = Convert.ToDouble(dgv1.Rows[1].Cells[0].Value) +
                Convert.ToDouble(dgv1.Rows[1].Cells[1].Value) +
                Convert.ToDouble(dgv1.Rows[1].Cells[2].Value) +
                Convert.ToDouble(dgv1.Rows[1].Cells[3].Value) +
                Convert.ToDouble(dgv1.Rows[1].Cells[4].Value);
            double a3 = Convert.ToDouble(dgv1.Rows[2].Cells[0].Value) +
                Convert.ToDouble(dgv1.Rows[2].Cells[1].Value) +
                Convert.ToDouble(dgv1.Rows[2].Cells[2].Value) +
                Convert.ToDouble(dgv1.Rows[2].Cells[3].Value) +
                Convert.ToDouble(dgv1.Rows[2].Cells[4].Value);
            double a4 = Convert.ToDouble(dgv1.Rows[3].Cells[0].Value) +
                Convert.ToDouble(dgv1.Rows[3].Cells[1].Value) +
                Convert.ToDouble(dgv1.Rows[3].Cells[2].Value) +
                Convert.ToDouble(dgv1.Rows[3].Cells[3].Value) +
                Convert.ToDouble(dgv1.Rows[3].Cells[4].Value);
            double a5 = Convert.ToDouble(dgv1.Rows[4].Cells[0].Value) +
                Convert.ToDouble(dgv1.Rows[4].Cells[1].Value) +
                Convert.ToDouble(dgv1.Rows[4].Cells[2].Value) +
                Convert.ToDouble(dgv1.Rows[4].Cells[3].Value) +
                Convert.ToDouble(dgv1.Rows[4].Cells[4].Value);

            double a = a1 + a2 + a3 + a4 + a5;
            w1 = a1 / a;
            w2 = a2 / a;
            w3 = a3 / a;
            w4 = a4 / a;
            w5 = a5 / a;

            dgv1.Rows[5].Cells[0].Value = Math.Round(w1, 3);
            dgv1.Rows[5].Cells[1].Value = Math.Round(w2, 3);
            dgv1.Rows[5].Cells[2].Value = Math.Round(w3, 3);
            dgv1.Rows[5].Cells[3].Value = Math.Round(w4, 3);
            dgv1.Rows[5].Cells[4].Value = Math.Round(w5, 3);
        }
    }
}
