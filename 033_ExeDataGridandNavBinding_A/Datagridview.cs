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
    public partial class Datagridview : Form
    {
        public Datagridview()
        {
            InitializeComponent();
        }

        private void Datagridview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //Warna font pada satu kolom
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Orange;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.HotPink;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.YellowGreen;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.BlueViolet;

            //Warna kursor
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Purple;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Blue;

            //Membuat data bagian jenis kelamin menjadi center
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Mainmenu().Show();
            this.Hide();
        }
    }
}
