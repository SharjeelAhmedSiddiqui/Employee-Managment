using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EMPLOY_MANGMENT
{
    public partial class TOTAL_EMPLOYS : Form
    {
        public TOTAL_EMPLOYS()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition4.ShowSync(this);
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TOTAL_EMPLOYS_Load(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines("abbas.txt");
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Id");
            table.Columns.Add("Cell Number");
            table.Columns.Add("Salary");

            // string[] arr1 = new string[3];
            for (int i = 0; i < arr.Length; i = i + 4)
            {
                //  table.Columns.Add(arr[i]);
                string b = arr[i];
                // FileInfo file = new FileInfo(b);
                table.Rows.Add(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
            }
            dataGridView1.DataSource = table;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main_page mn = new main_page();
            this.Hide();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int n = dataGridView1.Rows.Add();
            //dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            //dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            //dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            //dataGridView1.Rows[n].Cells[3].Value = textBox4.Text;

            StreamWriter sw = new StreamWriter("abbas.txt", true);
            {
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.Close();
            }
            string[] arr = File.ReadAllLines("abbas.txt");
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Id");
            table.Columns.Add("Cell Number");
            table.Columns.Add("Salary");

          
            for (int i = 0; i < arr.Length; i = i + 4)
            {
                
                string b = arr[i];
                
                table.Rows.Add(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
                
            }
            dataGridView1.DataSource = table;
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines("abbas.txt");
            int count = 0;
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            while (count<4)
            {
               
                count++;
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string[] arr = File.ReadAllLines("abbas.txt");
            //DataTable table = new DataTable();
            //table.Columns.Add("Name");
            //table.Columns.Add("Id");
            //table.Columns.Add("Cell Number");
            //table.Columns.Add("Salary");

            //// string[] arr1 = new string[3];
            //for (int i = 0; i < arr.Length; i=i+4)
            //{
            //  //  table.Columns.Add(arr[i]);
            //    string b = arr[i];
            //   // FileInfo file = new FileInfo(b);
            //    table.Rows.Add(arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
            //}
            //dataGridView1.DataSource = table;
        }
    }
}

