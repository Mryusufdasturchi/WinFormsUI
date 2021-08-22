using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public static string s="";
        public static string t = "";
        public Form2()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox2.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;






        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl41_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            userControl41.Visible = true;
            userControl41.BringToFront();
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl11.Visible = false;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            userControl11.Visible = true;
            userControl11.BringToFront();
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            button3.Visible = true;
           






        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            userControl11.Visible = false;
            userControl21.BringToFront();
            userControl21.Visible = true;
            userControl31.Visible = false;
            userControl41.Visible = false;







        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            userControl11.Visible = false;
            userControl31.BringToFront();
            userControl31.Visible = true;
            userControl21.Visible = false;
            userControl41.Visible = false;



        }

        private void UserControl41_Load_1(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
