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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font=new Font("Arial", 16);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsdb pdb = new productsdb();
            dataGridView1.DataSource = pdb.selectall();
        }
    }
}
