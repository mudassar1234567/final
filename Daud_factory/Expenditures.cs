﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daud_factory
{
    public partial class Expenditures : Form
    {
        public Expenditures()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO expenditures (Name, amount, date, expenditure_for) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            expendituredb edb = new expendituredb();
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            //textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Expenditures_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            expendituredb exdb = new expendituredb();
            dataGridView1.DataSource = exdb.selectall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            expendituredb idb = new expendituredb();
            idb.get(Int32.Parse(id));
            textBox1.Text = idb.name;
            textBox2.Text = idb.amount;
            dateTimePicker1.Text = idb.date;
            textBox4.Text = idb.expentidure;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update expenditures set Name='" + textBox1.Text + "', amount='" + textBox2.Text + "', date='" + dateTimePicker1.Text + "', expenditure_for='" + textBox4.Text +"' where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            expendituredb rdb = new expendituredb();
            dataGridView1.DataSource = rdb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from expenditures where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            expendituredb rdb = new expendituredb();
            dataGridView1.DataSource = rdb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
        }
    }
}
