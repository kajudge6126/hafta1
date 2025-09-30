using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tkmyo" && textBox2.Text == "1955")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
