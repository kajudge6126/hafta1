namespace hafta1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            comboBox1.Location = new Point(119, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(119, 132);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 4;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 176);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(202, 169);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Kişi Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 48);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Kişi Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Kişi Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 77);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Kişi Adı:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 354);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}