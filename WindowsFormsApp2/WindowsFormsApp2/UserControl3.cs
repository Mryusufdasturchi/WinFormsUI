using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControl3 : UserControl
    {
        public static string l;
        public static string x;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
          
           



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                label44.Text = (double.Parse(UserControl2.m) * 13.3).ToString();
                label12.Text = (double.Parse(UserControl2.m) * 7.5).ToString();
                label14.Text = (double.Parse(UserControl2.m) * 20).ToString();
                label42.Text = (double.Parse(label44.Text) + double.Parse(label12.Text) + double.Parse(label14.Text)).ToString();
                l = label42.Text;
                label43.Text = (double.Parse(label42.Text) / 900).ToString();
                x = label43.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Jadval hamma maydonni toldiring");
            }


          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label44.Text = "";
            label12.Text = "";
            label14.Text = "";
            label42.Text = "";
            label43.Text = "";

        }
    }
}
