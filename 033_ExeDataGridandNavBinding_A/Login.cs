using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _033_ExeDataGridandNavBinding_A
{
    public partial class Login : Form
    {
        readonly string Username = "Raihan";
        readonly string Password = "Raihan071201";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txusername.Text == Username && txpass.Text == Password)
            {
                new Mainmenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah. Username = Raihan, Password = Raihan071201  ");
                txusername.Clear();
                txpass.Clear();
                txusername.Focus();
                txpass.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
