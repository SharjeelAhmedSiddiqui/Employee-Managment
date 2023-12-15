using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace EMPLOY_MANGMENT
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition1.ShowSync(this);
        

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Form1 ad = new Form1();
            this.Hide();
            ad.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ADD_EMPLOY ad = new ADD_EMPLOY();
            this.Hide();
            ad.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            attendance_form ad = new attendance_form();
            this.Hide();
            ad.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            INFORMATION ad = new INFORMATION();
            this.Hide();
            ad.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            TOTAL_EMPLOYS te = new TOTAL_EMPLOYS();
            this.Hide();
            te.Show();

        }

        private void main_page_Load(object sender, EventArgs e)
        {

        }
    }
}
