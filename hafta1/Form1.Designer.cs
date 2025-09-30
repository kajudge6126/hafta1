namespace hafta1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            button7 = new Button();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(3, 32);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 0;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(30, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 64);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(30, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 96);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(206, 23);
            button2.TabIndex = 0;
            button2.Text = "Gönder";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(291, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 313);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(74, 210);
            label5.Name = "label5";
            label5.Size = new Size(110, 90);
            label5.TabIndex = 5;
            // 
            // button7
            // 
            button7.Location = new Point(74, 86);
            button7.Name = "button7";
            button7.Size = new Size(110, 25);
            button7.TabIndex = 5;
            button7.Text = "Tüm İşlemleri Gör";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 184);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(141, 147);
            button5.Name = "button5";
            button5.Size = new Size(43, 23);
            button5.TabIndex = 11;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(74, 147);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(43, 23);
            button6.TabIndex = 10;
            button6.Text = "/";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(141, 117);
            button4.Name = "button4";
            button4.Size = new Size(43, 23);
            button4.TabIndex = 9;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(74, 117);
            button3.Name = "button3";
            button3.Size = new Size(43, 23);
            button3.TabIndex = 5;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Sayı 2:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 20);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Sayı 1:";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 57);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 17);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button8);
            groupBox1.Location = new Point(534, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 313);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(114, 60);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(95, 229);
            listBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(95, 229);
            listBox1.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(72, 22);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 0;
            button8.Text = "Sayı Çek";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(798, 441);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "qqc";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button button7;
        public Label label5;
        private GroupBox groupBox1;
        private Button button8;
        private ListBox listBox2;
        private ListBox listBox1;
    }
}
