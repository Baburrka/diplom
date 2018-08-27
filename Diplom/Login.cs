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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 10;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "1234")
            {
                Main f2 = new Main();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароль введен неверно!", "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }
    }
}
