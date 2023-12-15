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
    public partial class attendance_form : Form
    {
        public attendance_form()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition4.ShowSync(this);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attendance_form_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

  main_page ad = new main_page();
            this.Hide();
            ad.Show();
        }
    }
}
