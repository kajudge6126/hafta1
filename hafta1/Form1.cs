namespace hafta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = textBox1.Text;
            MessageBox.Show(mesaj);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            int toplam = sayi1 - sayi2;
            label4.Text = Convert.ToString(toplam);
            // int sayi1 = Convert.ToInt32(textBox3.Text); // inte çevirmenin baþka yolu.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            int toplam = sayi1 * sayi2;
            label4.Text = Convert.ToString(toplam);
            // int sayi1 = Convert.ToInt32(textBox3.Text); // inte çevirmenin baþka yolu.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            int toplam = sayi1 + sayi2;
            label4.Text = Convert.ToString(toplam);
            // int sayi1 = Convert.ToInt32(textBox3.Text); // inte çevirmenin baþka yolu.

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            int toplam = sayi1 / sayi2;
            label4.Text = Convert.ToString(toplam);
            // int sayi1 = Convert.ToInt32(textBox3.Text); // inte çevirmenin baþka yolu.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj2 = textBox2.Text;
            // label1.Text = mesaj2;
            label1.Text = mesaj2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            int toplam = sayi1 + sayi2;
            int cikarma = sayi1 - sayi2;
            int carpma = sayi1 * sayi2;
            int bolme = sayi1 / sayi2;

            label5.Text = "Toplam=" + Convert.ToString(toplam);
            label5.Text += "\nFark=" + Convert.ToString(cikarma);
            label5.Text += "\nÇarpým=" + Convert.ToString(carpma);
            label5.Text += "\nBölüm=" + Convert.ToString(bolme);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(Convert.ToString(i));
                }
                else
                {
                    listBox1.Items.Add(Convert.ToString(i));
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
