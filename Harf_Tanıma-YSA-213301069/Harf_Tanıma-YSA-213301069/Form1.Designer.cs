namespace Harf_Tanıma_YSA_213301069
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            chat = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 48);
            label1.TabIndex = 0;
            label1.Text = "HADİ";
            // 
            // panel1
            // 
            panel1.Location = new Point(763, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 350);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(523, 156);
            button1.Name = "button1";
            button1.Size = new Size(150, 54);
            button1.TabIndex = 2;
            button1.Text = "Standart Eğitim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(523, 259);
            button2.Name = "button2";
            button2.Size = new Size(150, 54);
            button2.TabIndex = 4;
            button2.Text = "Test et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(523, 357);
            button5.Name = "button5";
            button5.Size = new Size(150, 54);
            button5.TabIndex = 7;
            button5.Text = "Model Yükle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(523, 452);
            button3.Name = "button3";
            button3.Size = new Size(150, 54);
            button3.TabIndex = 8;
            button3.Text = "Modeli Kaydet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(55, 156);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(345, 350);
            textBox1.TabIndex = 9;
            // 
            // chat
            // 
            chat.AutoSize = true;
            chat.Location = new Point(113, 113);
            chat.Name = "chat";
            chat.Size = new Size(780, 20);
            chat.TabIndex = 10;
            chat.Text = "Siz harfi yazdıktan sonra tahminlerimi söyleyeceğim efenim ama önce bir model eğitmeyi yada yüklemeyi unutmayın";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 57);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 12;
            label4.Text = "Harf Analizi ve Dinamik İşleyici";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 113);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 13;
            label5.Text = "HADİ :";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(874, 527);
            button4.Name = "button4";
            button4.Size = new Size(150, 54);
            button4.TabIndex = 14;
            button4.Text = "Matrisi Temizle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 544);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 15;
            label2.Text = "Hata Oranı = ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 541);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 27);
            textBox2.TabIndex = 16;
            textBox2.Text = "0.1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(19, 13);
            label6.Name = "label6";
            label6.Size = new Size(189, 28);
            label6.TabIndex = 17;
            label6.Text = "Federation Studios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1186, 597);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chat);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.MediumTurquoise;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button3;
        private TextBox textBox1;
        private Label chat;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
    }
}
