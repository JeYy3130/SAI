using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stacionar
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
           StaffAcc res = dbController.login_function(textBox1.Text, textBox2.Text);
            if (res != null)
            {
                MessageBox.Show("Вход выполнен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbController.logged = res;
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
