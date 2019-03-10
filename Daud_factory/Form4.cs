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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "1";
            dataGridView1.Rows[n].Cells[1].Value = "Osama Javaid";
            dataGridView1.Rows[n].Cells[2].Value = "H#124, st#8, sector C, Bahria town, Islamabad";
            dataGridView1.Rows[n].Cells[3].Value = "03331234567";
            dataGridView1.Rows[n].Cells[4].Value = "546082707896421";

            int x = dataGridView1.Rows.Add();
            dataGridView1.Rows[x].Cells[0].Value = "2";
            dataGridView1.Rows[x].Cells[1].Value = "Filza Gaba";
            dataGridView1.Rows[x].Cells[2].Value = "H#124, st#8, sector C, Bahria town, Islamabad";
            dataGridView1.Rows[x].Cells[3].Value = "03331234567";
            dataGridView1.Rows[x].Cells[4].Value = "546082707896421";

            int y = dataGridView1.Rows.Add();
            dataGridView1.Rows[y].Cells[0].Value = "3";
            dataGridView1.Rows[y].Cells[1].Value = "mudassar ali";
            dataGridView1.Rows[y].Cells[2].Value = "H#124, st#8, sector C, Bahria town, Islamabad";
            dataGridView1.Rows[y].Cells[3].Value = "03331234567";
            dataGridView1.Rows[y].Cells[4].Value = "546082707896421";

            int z = dataGridView1.Rows.Add();
            dataGridView1.Rows[z].Cells[0].Value = "4";
            dataGridView1.Rows[z].Cells[1].Value = "Saad sohail";
            dataGridView1.Rows[z].Cells[2].Value = "H#124, st#8, sector C, Bahria town, Islamabad";
            dataGridView1.Rows[z].Cells[3].Value = "03331234567";
            dataGridView1.Rows[z].Cells[4].Value = "546082707896421";

        }
    }
}
