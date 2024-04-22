
namespace WinFormsApp1
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(111, 376);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 62);
            button1.TabIndex = 8;
            button1.Text = "Ödemeyi Al ve Bitir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kredi Kartı", "Nakit" });
            comboBox1.Location = new System.Drawing.Point(431, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(431, 261);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Ödeme Aracı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(102, 261);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 20);
            label1.TabIndex = 6;
            label1.Text = "Sipariş Tutarı";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(102, 284);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(154, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(431, 376);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(145, 62);
            button2.TabIndex = 8;
            button2.Text = "Siparişi İptal Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new System.Drawing.Point(190, 182);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.ReadOnly = true;
            numericUpDown5.Size = new System.Drawing.Size(74, 27);
            numericUpDown5.TabIndex = 35;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(190, 149);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.ReadOnly = true;
            numericUpDown4.Size = new System.Drawing.Size(74, 27);
            numericUpDown4.TabIndex = 34;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(190, 116);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.ReadOnly = true;
            numericUpDown3.Size = new System.Drawing.Size(74, 27);
            numericUpDown3.TabIndex = 33;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(190, 83);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.ReadOnly = true;
            numericUpDown2.Size = new System.Drawing.Size(74, 27);
            numericUpDown2.TabIndex = 32;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(190, 50);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new System.Drawing.Size(74, 27);
            numericUpDown1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(156, 20);
            label5.TabIndex = 30;
            label5.Text = "Menu 5 Sipariş Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(156, 20);
            label4.TabIndex = 29;
            label4.Text = "Menu 4 Sipariş Miktarı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 20);
            label3.TabIndex = 28;
            label3.Text = "Menu 3 Sipariş Miktarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(28, 85);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(156, 20);
            label6.TabIndex = 27;
            label6.Text = "Menu 2 Sipariş Miktarı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(28, 52);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(156, 20);
            label7.TabIndex = 26;
            label7.Text = "Menu 1 Sipariş Miktarı";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(288, 113);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(500, 133);
            textBox4.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(648, 45);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(140, 27);
            textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(469, 43);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(173, 27);
            textBox2.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(288, 42);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new System.Drawing.Size(173, 27);
            textBox5.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(648, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(124, 20);
            label8.TabIndex = 36;
            label8.Text = "İletişim Numarası";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(288, 90);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 20);
            label9.TabIndex = 37;
            label9.Text = "Adres";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(469, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(107, 20);
            label10.TabIndex = 38;
            label10.Text = "Müşteri Soyadı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(288, 12);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(85, 20);
            label11.TabIndex = 39;
            label11.Text = "Müşteri Adı";
            // 
            // frmOdeme
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(799, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmOdeme";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ödeme Ekranı";
            Load += frmOdeme_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}