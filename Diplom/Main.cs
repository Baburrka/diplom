using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Diplom
{
    public partial class Main : Form
    {
        Matrix f3;
        double[] Y;
        public Main()
        {
            InitializeComponent();
            this.Height = 440;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void пациентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентыBindingSource6.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.saharny_diabetDataSet11);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saharny_diabetDataSet11.Пациенты' table. You can move, or remove it, as needed.
            this.пациентыTableAdapter1.Fill(this.saharny_diabetDataSet11.Пациенты);
        }

        private void VvodPrioritetov_Click(object sender, EventArgs e)
        {
            f3 = new Matrix();
            f3.Show();
        }

        private void Veroyatnost_Click(object sender, EventArgs e)
        {
            int sel = dgv2.CurrentCell.RowIndex;
            double[] mass = new double[8];
            Y = new double[11];
            //веса и значения парных критериев
            for (int i = 3; i <= 7; i++) 
            {
                if ((dgv2.Rows[sel].Cells[i].Value.ToString() == "есть") || (dgv2.Rows[sel].Cells[i].Value.ToString() == "часто") || (dgv2.Rows[sel].Cells[i].Value.ToString() ==  "постоянно") || (dgv2.Rows[sel].Cells[i].Value.ToString() == "повышенно"))
                    mass[i] = 1.000;
                if ((dgv2.Rows[sel].Cells[i].Value.ToString() == "редко") || (dgv2.Rows[sel].Cells[i].Value.ToString() == "по-разному"))
                    mass[i] = 0.600;
                if ((dgv2.Rows[sel].Cells[i].Value.ToString() == "нет") || (dgv2.Rows[sel].Cells[i].Value.ToString() == "умеренно"))
                    mass[i] = 0.000;
            }
            try //если забыли ввести веса
            {
                Y[1] = Math.Round(f3.w1 * mass[3] + f3.w2 * mass[4], 4);
                Y[2] = Math.Round(f3.w1 * mass[3] + f3.w3 * mass[5], 4);
                Y[3] = Math.Round(f3.w1 * mass[3] + f3.w4 * mass[6], 4);
                Y[4] = Math.Round(f3.w1 * mass[3] + f3.w5 * mass[7], 4);
                Y[5] = Math.Round(f3.w2 * mass[4] + f3.w3 * mass[5], 4);
                Y[6] = Math.Round(f3.w2 * mass[4] + f3.w4 * mass[6], 4);
                Y[7] = Math.Round(f3.w2 * mass[4] + f3.w5 * mass[7], 4);
                Y[8] = Math.Round(f3.w3 * mass[5] + f3.w4 * mass[6], 4);
                Y[9] = Math.Round(f3.w3 * mass[5] + f3.w5 * mass[7], 4);
                Y[10] = Math.Round(f3.w4 * mass[6] + f3.w5 * mass[7], 4);
                dgv2.Rows[sel].Cells[10].Value = Y[1];
                dgv2.Rows[sel].Cells[11].Value = Y[2];
                dgv2.Rows[sel].Cells[12].Value = Y[3];
                dgv2.Rows[sel].Cells[13].Value = Y[4];
                dgv2.Rows[sel].Cells[14].Value = Y[5];
                dgv2.Rows[sel].Cells[15].Value = Y[6];
                dgv2.Rows[sel].Cells[16].Value = Y[7];
                dgv2.Rows[sel].Cells[17].Value = Y[8];
                dgv2.Rows[sel].Cells[18].Value = Y[9];
                dgv2.Rows[sel].Cells[19].Value = Y[10];
            }
            catch (Exception ex) { };
            double Enter = 0, Yes = 0;
            double[] PDY = new double [11];

            for (int k = 1; k < 11; k++)
            {
                Enter = 0; Yes = 0;
                if ((0 <= Y[k]) & (Y[k] < 0.2))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.2))
                        {
                            Enter++;
                            if ((bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY[k] = Math.Round(Yes / Enter,4);
                }
                if ((0.2 <= Y[k]) & (Y[k] < 0.4))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.2) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.4))
                        {
                            Enter++;
                            if ((bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY[k] = Math.Round(Yes / Enter, 4);
                } if ((0.4 <= Y[k]) & (Y[k] < 0.6))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.4) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.6))
                        {
                            Enter++;
                            if ((bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY[k] = Math.Round(Yes / Enter, 4);
                } if ((0.6 <= Y[k]) & (Y[k] < 0.8))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.6) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.8))
                        {
                            Enter++;
                            if ((bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY[k] = Math.Round(Yes / Enter, 4);
                } if ((0.8 <= Y[k]) & (Y[k] <= 1))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.8) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) <= 1))
                        {
                            Enter++;
                            if ((bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY[k] = Math.Round(Yes / Enter, 4);
                }
            }

            double PD1 = 0, PD0 = 0, P = 0;
            int kol = 0;
            for (int i = 0; i < dgv2.RowCount - 2; i++)
            {
                if ((bool)dgv2.Rows[i].Cells[9].Value) 
                    kol++;
            }
            int k1 = dgv2.RowCount - 2;
            PD1 = (double)kol / (double)k1;
            PD0 = 1 - PD1;

            double[] PDY_ = new double[11];

            for (int k = 1; k < 11; k++)
            {
                Enter = 0; Yes = 0;
                if ((0 <= Y[k]) & (Y[k] < 0.2))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.2))
                        {
                            Enter++;
                            if (!(bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY_[k] = Math.Round(Yes / Enter, 4);
                }
                if ((0.2 <= Y[k]) & (Y[k] < 0.4))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.2) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.4))
                        {
                            Enter++;
                            if (!(bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY_[k] = Math.Round(Yes / Enter, 4);
                } if ((0.4 <= Y[k]) & (Y[k] < 0.6))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.4) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.6))
                        {
                            Enter++;
                            if (!(bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY_[k] = Math.Round(Yes / Enter, 4);
                } if ((0.6 <= Y[k]) & (Y[k] < 0.8))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.6) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) < 0.8))
                        {
                            Enter++;
                            if (!(bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY_[k] = Math.Round(Yes / Enter, 4);
                } if ((0.8 <= Y[k]) & (Y[k] <= 1))
                {
                    for (int i = 0; i < dgv2.RowCount - 2; i++)
                    {
                        if ((Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) >= 0.8) & (Convert.ToDouble(dgv2.Rows[i].Cells[k + 9].Value) <= 1))
                        {
                            Enter++;
                            if (!(bool)dgv2.Rows[i].Cells[9].Value)
                            { Yes++; }
                        }
                    }
                    PDY_[k] = Math.Round(Yes / Enter, 4);
                }
            }
            //не учитываем Y если оно равно 0
            for (int i = 1; i < 11; i++)
            {
                if (PDY[i] == 0) PDY[i] = 1;
                if (PDY_[i] == 0) PDY_[i] = 1;
            }
                P = (PD1 * PDY[1] * PDY[2] * PDY[3] * PDY[4] * PDY[5] * PDY[6] * PDY[7] * PDY[8] * PDY[9] * PDY[10]) /
                    ((PD1 * PDY[1] * PDY[2] * PDY[3] * PDY[4] * PDY[5] * PDY[6] * PDY[7] * PDY[8] * PDY[9] * PDY[10]) +
                    (PD0 * PDY_[1] * PDY_[2] * PDY_[3] * PDY_[4] * PDY_[5] * PDY_[6] * PDY_[7] * PDY_[8] * PDY_[9] * PDY_[10]));
            dgv2.Rows[sel].Cells[8].Value = Math.Round(P,3);
        }

        private void Function_Click(object sender, EventArgs e)
        {
            if ((dgv2.CurrentCell.Value.ToString() == "есть") || (dgv2.CurrentCell.Value.ToString() == "часто") || (dgv2.CurrentCell.Value.ToString() == "постоянно") || (dgv2.CurrentCell.Value.ToString() == "повышенно"))
            {
                Function f = new Function();
                f.Show();
                f.g.FillEllipse(Brushes.Red, 187, 57, 6, 6);
            }
            if ((dgv2.CurrentCell.Value.ToString() == "редко") || (dgv2.CurrentCell.Value.ToString() == "по-разному"))
            {
                Function f = new Function();
                f.Show();
                f.g.FillEllipse(Brushes.Red, 123, 119, 6, 6);
            }
            if ((dgv2.CurrentCell.Value.ToString() == "нет") || (dgv2.CurrentCell.Value.ToString() == "умеренно"))
            {
                Function f = new Function();
                f.Show();
                f.g.FillEllipse(Brushes.Red, 37, 207, 6, 6);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Height = 525;
        }

        private void VvestiSimptomy_Click(object sender, EventArgs e)
        {
            this.Height = 440;
            dgv2.Rows[dgv2.RowCount - 2].Cells[3].Value = comboBox1.Text;
            dgv2.Rows[dgv2.RowCount - 2].Cells[4].Value = comboBox2.Text;
            dgv2.Rows[dgv2.RowCount - 2].Cells[5].Value = comboBox3.Text;
            dgv2.Rows[dgv2.RowCount - 2].Cells[6].Value = comboBox4.Text;
            dgv2.Rows[dgv2.RowCount - 2].Cells[7].Value = comboBox5.Text;
            dgv2.Rows[dgv2.RowCount - 2].Cells[0].Value = dgv2.RowCount - 1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv2.RowCount - 1; i++)
            {
                dgv2.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
