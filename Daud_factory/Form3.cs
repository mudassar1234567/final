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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "1";
            dataGridView1.Rows[n].Cells[1].Value = "PVC normal";
            dataGridView1.Rows[n].Cells[2].Value = "8";
            dataGridView1.Rows[n].Cells[3].Value = "350";
            dataGridView1.Rows[n].Cells[4].Value = "1280";

            int x = dataGridView1.Rows.Add();
            dataGridView1.Rows[x].Cells[0].Value = "2";
            dataGridView1.Rows[x].Cells[1].Value = "PVC presure";
            dataGridView1.Rows[x].Cells[2].Value = "12";
            dataGridView1.Rows[x].Cells[3].Value = "150";
            dataGridView1.Rows[x].Cells[4].Value = "1580";

            int y = dataGridView1.Rows.Add();
            dataGridView1.Rows[y].Cells[0].Value = "3";
            dataGridView1.Rows[y].Cells[1].Value = "PVC super";
            dataGridView1.Rows[y].Cells[2].Value = "15";
            dataGridView1.Rows[y].Cells[3].Value = "50";
            dataGridView1.Rows[y].Cells[4].Value = "1880";
        }
    }
}
