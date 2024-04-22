
namespace WinFormsApp1
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Madi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Madi, MSoyadi, MTel, MAdres });
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(554, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Madi
            // 
            Madi.DataPropertyName = "MusteriAdi";
            Madi.HeaderText = "Müşteri Adı";
            Madi.MinimumWidth = 6;
            Madi.Name = "Madi";
            Madi.Width = 125;
            // 
            // MSoyadi
            // 
            MSoyadi.DataPropertyName = "MusteriSoyadi";
            MSoyadi.HeaderText = "Müşteri Soyadı";
            MSoyadi.MinimumWidth = 6;
            MSoyadi.Name = "MSoyadi";
            MSoyadi.Width = 125;
            // 
            // MTel
            // 
            MTel.DataPropertyName = "MusteriTel";
            MTel.HeaderText = "Telefon";
            MTel.MinimumWidth = 6;
            MTel.Name = "MTel";
            MTel.Width = 125;
            // 
            // MAdres
            // 
            MAdres.DataPropertyName = "MusteriAdres";
            MAdres.HeaderText = "Müşteri Adres";
            MAdres.MinimumWidth = 6;
            MAdres.Name = "MAdres";
            MAdres.Width = 125;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(460, 400);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 34);
            button1.TabIndex = 1;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 439);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmMusteriler";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Müşteriler";
            Load += frmMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAdres;
        private System.Windows.Forms.Button button1;
    }
}