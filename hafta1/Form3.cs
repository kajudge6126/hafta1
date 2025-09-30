using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyisim = textBox2.Text;
            string dyeri = textBox3.Text;
            string yas = Convert.ToString(2025 - Convert.ToInt32(comboBox1.Text));

            listBox1.Items.Add("İsim: "+Convert.ToString(isim));
            listBox1.Items.Add("Soyisim: "+Convert.ToString(soyisim));
            listBox1.Items.Add("Doğum Yeri: "+Convert.ToString(dyeri));
            listBox1.Items.Add("Yaş: "+Convert.ToString(yas));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
