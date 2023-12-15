using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOY_MANGMENT
{
    public partial class startingform : Form
    {
        public startingform()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void startingform_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition3.ShowSync(this);
        }
    }
}
