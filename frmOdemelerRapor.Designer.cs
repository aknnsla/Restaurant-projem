
namespace WinFormsApp1
{
    partial class frmOdemelerRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemelerRapor));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Menu1Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Menu2Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Menu3Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Menu4Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Menu5Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OdemeTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Menu1Adet, Menu2Adet, Menu3Adet, Menu4Adet, Menu5Adet, Tutar, OdemeTipi });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(932, 367);
            dataGridView1.TabIndex = 0;
            // 
            // Menu1Adet
            // 
            Menu1Adet.DataPropertyName = "Menu1Adet";
            Menu1Adet.HeaderText = "Menu 1 Toplam Adet";
            Menu1Adet.MinimumWidth = 6;
            Menu1Adet.Name = "Menu1Adet";
            Menu1Adet.Width = 125;
            // 
            // Menu2Adet
            // 
            Menu2Adet.DataPropertyName = "Menu2Adet";
            Menu2Adet.HeaderText = "Menu 2 Toplam Adet";
            Menu2Adet.MinimumWidth = 6;
            Menu2Adet.Name = "Menu2Adet";
            Menu2Adet.Width = 125;
            // 
            // Menu3Adet
            // 
            Menu3Adet.DataPropertyName = "Menu3Adet";
            Menu3Adet.HeaderText = "Menu 3 Toplam Adet";
            Menu3Adet.MinimumWidth = 6;
            Menu3Adet.Name = "Menu3Adet";
            Menu3Adet.Width = 125;
            // 
            // Menu4Adet
            // 
            Menu4Adet.DataPropertyName = "Menu4Adet";
            Menu4Adet.HeaderText = "Menu 4 Toplam Adet";
            Menu4Adet.MinimumWidth = 6;
            Menu4Adet.Name = "Menu4Adet";
            Menu4Adet.Width = 125;
            // 
            // Menu5Adet
            // 
            Menu5Adet.DataPropertyName = "Menu5Adet";
            Menu5Adet.HeaderText = "Menu 5 Toplam Adet";
            Menu5Adet.MinimumWidth = 6;
            Menu5Adet.Name = "Menu5Adet";
            Menu5Adet.Width = 125;
            // 
            // Tutar
            // 
            Tutar.DataPropertyName = "Tutar";
            Tutar.HeaderText = "Tutar";
            Tutar.MinimumWidth = 6;
            Tutar.Name = "Tutar";
            Tutar.Width = 125;
            // 
            // OdemeTipi
            // 
            OdemeTipi.DataPropertyName = "OdemeTipi";
            OdemeTipi.HeaderText = "Ödeme Tipi";
            OdemeTipi.MinimumWidth = 6;
            OdemeTipi.Name = "OdemeTipi";
            OdemeTipi.Width = 125;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(848, 385);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 37);
            button1.TabIndex = 1;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmOdemelerRapor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(954, 434);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmOdemelerRapor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ödemeler Rapor";
            Load += frmOdemelerRapor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu1Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu2Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu3Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu4Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu5Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeTipi;
        private System.Windows.Forms.Button button1;
    }
}