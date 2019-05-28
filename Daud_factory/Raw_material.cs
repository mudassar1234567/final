using System;
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
    public partial class Rawmaterial : Form
    {
        public SqlDataAdapter da;
        public DataTable dt;

        public Rawmaterial()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            raw_materialdb edb = new raw_materialdb();
            double x,y;
            y = float.Parse(textBox2.Text);
            if (comboBox1.Text== "Resin")
            {
                edb.get(1);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
            else if (comboBox1.Text == "UVtax")
            {
                edb.get(2);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
            else if (comboBox1.Text == "One pack")
            {
                edb.get(4);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
            else if (comboBox1.Text == "Titanium")
            {
                edb.get(5);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
            else if (comboBox1.Text == "DOP")
            {
                edb.get(6);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
            else if (comboBox1.Text == "Chowk powder")
            {
                edb.get(7);
                x = edb.quantity + y;
                cmd.CommandText = "update raw_material set quantity='" + x + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                this.Close();
                Rawmaterial f13 = new Rawmaterial();
                f13.ShowDialog();
            }
        }

        private void Rawmaterial_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            raw_materialdb rmdb = new raw_materialdb();
            dataGridView1.DataSource = rmdb.selectall();
            raw_materialdb idb = new raw_materialdb();
            for (int i = 1; i <= 7; i++)
            {
                if (i != 3)
                {
                    raw_materialdb rdb = new raw_materialdb();
                    rdb.get(i);
                    comboBox1.Items.Add(rdb.name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            raw_materialdb idb = new raw_materialdb();
            idb.get(Int32.Parse(id));
            comboBox1.Text = idb.name;
            textBox2.Text = idb.quantity+"";
            textBox3.Text = idb.cost;
            textBox4.Text = idb.purchased_from;
            dateTimePicker1.Text = idb.purchase_date;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update raw_material set name='" + comboBox1.Text + "', quantity='" + textBox2.Text + "', cost='" + textBox3.Text + "', purchased_from='" + textBox4.Text + "', purchase_date='" + dateTimePicker1.Text + "' where name='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            raw_materialdb rdb = new raw_materialdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = rdb.selectall();
            con.Close();
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update raw_material set  quantity='" + 0 + "' where name='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            raw_materialdb rdb = new raw_materialdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = rdb.selectall();
            con.Close();
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
