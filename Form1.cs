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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            bunifuTransition2.ShowSync(this);


        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox2.Text == "talha" && bunifuMetroTextbox1.Text == "1234")
            {
                Console.WriteLine(MessageBox.Show("LOGIN SUCCESSFULL !"));
                main_page mn = new main_page();
                this.Hide();
                mn.Show();
            }
            else if(bunifuMetroTextbox1.Text == null && bunifuMetroTextbox2.Text == null || bunifuMetroTextbox1.Text == null)
            {
                Console.WriteLine(MessageBox.Show("INVALID !"));
            }
            else
            {
                Console.WriteLine(MessageBox.Show("LOGIN FAILED !"));
            } 
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startingform sf = new startingform();
            this.Hide();
            sf.Show();
        }
    }
}
