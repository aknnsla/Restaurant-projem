
namespace WinFormsApp1
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            panel1 = new System.Windows.Forms.Panel();
            btnOdeme = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Adres = new System.Windows.Forms.Button();
            btnSiparis = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnOdeme);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Adres);
            panel1.Controls.Add(btnSiparis);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(548, 153);
            panel1.TabIndex = 1;
            // 
            // btnOdeme
            // 
            btnOdeme.Image = (System.Drawing.Image)resources.GetObject("btnOdeme.Image");
            btnOdeme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnOdeme.Location = new System.Drawing.Point(429, 3);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new System.Drawing.Size(111, 147);
            btnOdeme.TabIndex = 0;
            btnOdeme.Text = "Ödemeler";
            btnOdeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(161, 147);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Adres
            // 
            Adres.Image = (System.Drawing.Image)resources.GetObject("Adres.Image");
            Adres.Location = new System.Drawing.Point(308, 3);
            Adres.Name = "Adres";
            Adres.Size = new System.Drawing.Size(115, 147);
            Adres.TabIndex = 0;
            Adres.Text = "Müşteriler";
            Adres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            Adres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            Adres.UseVisualStyleBackColor = true;
            Adres.Click += Adres_Click_1;
            // 
            // btnSiparis
            // 
            btnSiparis.Image = (System.Drawing.Image)resources.GetObject("btnSiparis.Image");
            btnSiparis.Location = new System.Drawing.Point(181, 3);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new System.Drawing.Size(121, 147);
            btnSiparis.TabIndex = 0;
            btnSiparis.Text = "Sipariş Oluştur";
            btnSiparis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(148, 178);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Menü 1 Satış Adeti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(148, 211);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 20);
            label2.TabIndex = 2;
            label2.Text = "Menü 2 Satış Adeti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(148, 244);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Menü 3 Satış Adeti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(148, 277);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 20);
            label4.TabIndex = 2;
            label4.Text = "Menü 4 Satış Adeti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(148, 310);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(133, 20);
            label5.TabIndex = 2;
            label5.Text = "Menü 5 Satış Adeti";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(290, 175);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(160, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(290, 208);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(160, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(290, 241);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(160, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(290, 274);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(160, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(290, 307);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new System.Drawing.Size(160, 27);
            textBox5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(148, 343);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(144, 20);
            label6.TabIndex = 2;
            label6.Text = "Toplam Satış Miktarı";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(290, 340);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(160, 27);
            textBox6.TabIndex = 3;
            // 
            // frmAnasayfa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 374);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmAnasayfa";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "yemek sipariş";
            Load += frmAnasayfa_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Adres;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}

