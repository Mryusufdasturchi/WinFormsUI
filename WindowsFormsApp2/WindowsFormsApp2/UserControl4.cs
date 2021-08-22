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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label42.Text = "";

            label43.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label42.Text = UserControl3.l;
            label43.Text = UserControl3.x;
        }
    }
}
