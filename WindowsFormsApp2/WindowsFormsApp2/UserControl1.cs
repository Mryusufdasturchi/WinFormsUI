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
    public partial class UserControl1 : UserControl
    {
        public static string s;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                label36.Text = (double.Parse(textBox1.Text) * 0.8).ToString();
                label37.Text = (double.Parse(textBox2.Text) * 0.2).ToString();
                label38.Text = (double.Parse(textBox3.Text) * 1).ToString();
                label39.Text = (double.Parse(textBox4.Text) * 0.4).ToString();
                label40.Text = (double.Parse(textBox5.Text) * 0.5).ToString();
                label41.Text = (double.Parse(textBox6.Text) * 0.15).ToString();
                label42.Text = (double.Parse(textBox7.Text) * 1).ToString();
                label43.Text = (double.Parse(textBox8.Text) * 1).ToString();
                label44.Text = (double.Parse(textBox9.Text) * 0.4).ToString();

                label46.Text = (double.Parse(label36.Text) + double.Parse(label37.Text)  + double.Parse(label38.Text)+ double.Parse( label39.Text) + double.Parse(label40.Text)  + double.Parse(label41.Text) + double.Parse(label42.Text) + double.Parse(label43.Text) + double.Parse(label44.Text)).ToString();
                s = label46.Text;







            }
            catch (Exception)
            {

                MessageBox.Show("Jadval hamma maydonni toldiring");

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label36.Text = "";
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            label40.Text = "";
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            label44.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            label46.Text = "";






        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
