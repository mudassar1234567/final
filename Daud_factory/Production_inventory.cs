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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventorydb idb = new inventorydb();
            dataGridView1.DataSource= idb.selectall();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            inventorydb idb = new inventorydb();
            idb.get(Int32.Parse(id));
            //textBox1.Text = idb.name;
            //MessageBox.Show(id);
        }
    }
}
