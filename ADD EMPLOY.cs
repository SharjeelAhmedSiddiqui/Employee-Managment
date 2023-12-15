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
using Bunifu.Framework.UI;





namespace EMPLOY_MANGMENT
{
    public partial class ADD_EMPLOY : Form
    {
        public ADD_EMPLOY()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition4.ShowSync(this);
            this.Visible = false;
            bunifuTransition6.ShowSync(this);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            savedata sv = new savedata();
            sv.saveinfo(bunifuMetroTextbox3
                , bunifuMetroTextbox2, bunifuMetroTextbox1, bunifuMetroTextbox4, bunifuMetroTextbox5, bunifuMetroTextbox7, bunifuMetroTextbox8, bunifuMetroTextbox9, bunifuMetroTextbox10, bunifuMetroTextbox11);
            updateinfo ud = new updateinfo();
            ud.showGridView(listView1, bunifuMetroTextbox3);



            //DataTable dt = new DataTable();
            //dt.Columns.Add(bunifuMetroTextbox1.Text);
            //dt.Columns.Add(bunifuMetroTextbox2.Text);
            //dt.Columns.Add(bunifuMetroTextbox3.Text);
            //dt.Columns.Add(bunifuMetroTextbox4.Text);
            //dt.Columns.Add(bunifuMetroTextbox5.Text);
            //dt.Columns.Add(bunifuMetroTextbox7.Text);
            //dt.Columns.Add(bunifuMetroTextbox8.Text);
            //dt.Columns.Add(bunifuMetroTextbox9.Text);
            //dt.Columns.Add(bunifuMetroTextbox10.Text);
            //dt.Columns.Add(bunifuMetroTextbox11.Text);
            //DataRow row = dt.NewRow();
            //row["name"] = bunifuMetroTextbox1.Text;
            //row["father's name"] = bunifuMetroTextbox2.Text;
            //row["employ id"] = bunifuMetroTextbox3.Text;
            //row["address"] = bunifuMetroTextbox4.Text;
            //row["cell #"] = bunifuMetroTextbox5.Text;
            //row["cnic"] = bunifuMetroTextbox7.Text;
            //row["gender"] = bunifuMetroTextbox8.Text;
            //row["department"] = bunifuMetroTextbox9.Text;
            //row["shift"] = bunifuMetroTextbox10.Text;
            //row["basic salary"] = bunifuMetroTextbox1.Text;
            //dataGridView1.DataSource = dt;

            //foreach (DataRow drow in dt.Rows)
            //{
            //    int num = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[num].Cells[0].Value = drow["name"].ToString();
            //    dataGridView1.Rows[num].Cells[1].Value = drow["father's name"].ToString();
            //    dataGridView1.Rows[num].Cells[2].Value = drow["employ id"].ToString();
            //    dataGridView1.Rows[num].Cells[3].Value = drow["address"].ToString();
            //    dataGridView1.Rows[num].Cells[4].Value = drow["cell #"].ToString();
            //    dataGridView1.Rows[num].Cells[5].Value = drow["cnic"].ToString();
            //    dataGridView1.Rows[num].Cells[6].Value = drow["gender"].ToString();
            //    dataGridView1.Rows[num].Cells[7].Value = drow["department"].ToString();
            //    dataGridView1.Rows[num].Cells[8].Value = drow["shift"].ToString();
            //    dataGridView1.Rows[num].Cells[9].Value = drow["basic salary"].ToString();

            //}




            //StreamWriter userData = new StreamWriter("UserData.txt", true);
            //userData.WriteLine(bunifuMetroTextbox1.Text);
            //userData.WriteLine(bunifuMetroTextbox2.Text);
            //userData.WriteLine(bunifuMetroTextbox3.Text);
            //userData.WriteLine(bunifuMetroTextbox4.Text);
            //userData.WriteLine(bunifuMetroTextbox5.Text);
            //userData.WriteLine(bunifuMetroTextbox7.Text);
            //userData.WriteLine(bunifuMetroTextbox8.Text);




            //userData.Close();



        }

        private void ADD_EMPLOY_Load(object sender, EventArgs e)
        {
            ListViewItem lvm = new ListViewItem();
            string[] arr = File.ReadAllLines("log.txt");
            string[] bekar = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                lvm.SubItems.Add(arr[i]);
            }
            listView1.Items.Add(lvm);
        }







        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox7.Text = "";
            bunifuMetroTextbox8.Text = "";
            bunifuMetroTextbox9.Text = "";
            bunifuMetroTextbox10.Text = "";
            bunifuMetroTextbox11.Text = "";        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            main_page ad = new main_page();
            this.Hide();
            ad.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox7.Text = "";
            bunifuMetroTextbox8.Text = "";
            bunifuMetroTextbox9.Text = "";
            bunifuMetroTextbox10.Text = "";
            bunifuMetroTextbox11.Text = "";

        }
    }
}
    


