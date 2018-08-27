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
    public partial class Function : Form
    {
        public Graphics g;
        public Bitmap bmp;
        public Function()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Brushes.Black), 40, 210, 210, 210);
            g.DrawLine(new Pen(Brushes.Black), 40, 210, 40, 40);
            g.FillEllipse(Brushes.Black, 188, 208, 4, 4); //1x
            g.FillEllipse(Brushes.Black, 38, 58, 4, 4); //1y
            g.FillEllipse(Brushes.Black, 127, 208, 4, 4); //0,6x
            g.FillEllipse(Brushes.Black, 38, 117, 4, 4); //0,6y
            g.DrawString("0", new Font("Microsoft Sans Serif", 12), Brushes.Black, 35, 210);
            g.DrawString("Есть", new Font("Microsoft Sans Serif", 8F), Brushes.Black, 180, 213); //x
            g.DrawString("1", new Font("Microsoft Sans Serif", 12F), Brushes.Black, 25, 58); //y
            g.DrawString("0,6", new Font("Microsoft Sans Serif", 12F), Brushes.Black, 12, 117); //y
            g.DrawString("Слабый", new Font("Microsoft Sans Serif", 8F), Brushes.Black, 110, 213); //x
            g.DrawString("признак", new Font("Microsoft Sans Serif", 8F), Brushes.Black, 109, 225); //x
            g.DrawString("Fi", new Font("Microsoft Sans Serif", 12F), Brushes.Black, 20, 30);
            g.DrawString("X", new Font("Microsoft Sans Serif", 12F), Brushes.Black, 210, 210);
        }
    }
}
