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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesdb sdb = new salesdb();
            dataGridView1.DataSource = sdb.selectall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
