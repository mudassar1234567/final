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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventory f2 = new inventory();
            f2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HRM f8 = new HRM();
            f8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products f3 = new Products();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer f4 = new Customer();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recipt f5 = new Recipt();
            f5.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Orders f9 = new Orders();
            f9.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sales f10 = new Sales();
            f10.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Expenditures f11= new Expenditures();
            f11.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Reports f12 = new Reports();
            f12.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Rawmaterial f13 = new Rawmaterial();
            f13.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Formulation f14 = new Formulation();
            f14.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            for (int i = 1; i < 7; i++)
            {
                if (i != 2)
                {
                    expendituredb cdb = new expendituredb();
                    cdb.get(i);
                    chart1.Series["Expenditures"].Points.AddXY(cdb.name, cdb.amount);
                }
            }


            for (int i = 1; i <= 7; i++)
            {
                if (i!=3) { 
                    raw_materialdb idb = new raw_materialdb();
                    idb.get(i);
                    chart2.Series["Material"].Points.AddXY(idb.name, idb.quantity);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
