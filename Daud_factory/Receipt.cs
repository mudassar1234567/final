using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daud_factory
{
    public partial class Recipt : Form
    {
        public Recipt()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int num1 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            int total;
            String q, nr;
            dataGridView1.Rows[n].Cells[0].Value = num1;
            dataGridView1.Rows[n].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;
            q= textBox2.Text; 
            nr= textBox3.Text;
            int x = int.Parse(q);
            int y = int.Parse(nr);
            total = x * y;
            dataGridView1.Rows[n].Cells[4].Value = total;
            num1++;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            this.Close();
            Recipt f5 = new Recipt();
            f5.ShowDialog();
        }

        private void Recipt_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
