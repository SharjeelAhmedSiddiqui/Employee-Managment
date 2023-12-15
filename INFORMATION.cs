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
    public partial class INFORMATION : Form
    {
        public INFORMATION()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition5.ShowSync(this);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main_page mn = new main_page();
            this.Hide();
            mn.Show();
        }

        private void INFORMATION_Load(object sender, EventArgs e)
        {

        }
    }
}
