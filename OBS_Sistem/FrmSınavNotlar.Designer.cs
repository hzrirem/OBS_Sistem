
namespace OBS_Sistem
{
    partial class FrmSınavNotlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CMBDERS = new System.Windows.Forms.ComboBox();
            this.TXTS1 = new System.Windows.Forms.TextBox();
            this.TXTS2 = new System.Windows.Forms.TextBox();
            this.TXTS3 = new System.Windows.Forms.TextBox();
            this.TXTPROJE = new System.Windows.Forms.TextBox();
            this.TXTORT = new System.Windows.Forms.TextBox();
            this.TXTDURUM = new System.Windows.Forms.TextBox();
            this.btntemzle = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(173, 15);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(153, 20);
            this.TXTID.TabIndex = 44;
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Location = new System.Drawing.Point(93, 22);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(73, 13);
            this.LABEL2.TabIndex = 42;
            this.LABEL2.Text = "ÖĞRENCİ ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "DERS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "SINAV 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "SINAV 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "SINAV 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "PROJE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "ORTALAMA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "DURUM:";
            // 
            // CMBDERS
            // 
            this.CMBDERS.FormattingEnabled = true;
            this.CMBDERS.Location = new System.Drawing.Point(173, 40);
            this.CMBDERS.Name = "CMBDERS";
            this.CMBDERS.Size = new System.Drawing.Size(153, 21);
            this.CMBDERS.TabIndex = 53;
            // 
            // TXTS1
            // 
            this.TXTS1.Location = new System.Drawing.Point(173, 67);
            this.TXTS1.Name = "TXTS1";
            this.TXTS1.Size = new System.Drawing.Size(153, 20);
            this.TXTS1.TabIndex = 54;
            // 
            // TXTS2
            // 
            this.TXTS2.Location = new System.Drawing.Point(173, 93);
            this.TXTS2.Name = "TXTS2";
            this.TXTS2.Size = new System.Drawing.Size(153, 20);
            this.TXTS2.TabIndex = 55;
            // 
            // TXTS3
            // 
            this.TXTS3.Location = new System.Drawing.Point(173, 119);
            this.TXTS3.Name = "TXTS3";
            this.TXTS3.Size = new System.Drawing.Size(153, 20);
            this.TXTS3.TabIndex = 56;
            // 
            // TXTPROJE
            // 
            this.TXTPROJE.Location = new System.Drawing.Point(515, 15);
            this.TXTPROJE.Name = "TXTPROJE";
            this.TXTPROJE.Size = new System.Drawing.Size(153, 20);
            this.TXTPROJE.TabIndex = 57;
            // 
            // TXTORT
            // 
            this.TXTORT.Location = new System.Drawing.Point(515, 41);
            this.TXTORT.Name = "TXTORT";
            this.TXTORT.Size = new System.Drawing.Size(153, 20);
            this.TXTORT.TabIndex = 58;
            // 
            // TXTDURUM
            // 
            this.TXTDURUM.Location = new System.Drawing.Point(515, 67);
            this.TXTDURUM.Name = "TXTDURUM";
            this.TXTDURUM.Size = new System.Drawing.Size(153, 20);
            this.TXTDURUM.TabIndex = 59;
            // 
            // btntemzle
            // 
            this.btntemzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemzle.Location = new System.Drawing.Point(512, 131);
            this.btntemzle.Name = "btntemzle";
            this.btntemzle.Size = new System.Drawing.Size(75, 23);
            this.btntemzle.TabIndex = 60;
            this.btntemzle.Text = "Temizle";
            this.btntemzle.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapla.Location = new System.Drawing.Point(512, 102);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 61;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngüncelle.Location = new System.Drawing.Point(593, 102);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 62;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnara
            // 
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Location = new System.Drawing.Point(593, 131);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 63;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // FrmSınavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(803, 368);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btntemzle);
            this.Controls.Add(this.TXTDURUM);
            this.Controls.Add(this.TXTORT);
            this.Controls.Add(this.TXTPROJE);
            this.Controls.Add(this.TXTS3);
            this.Controls.Add(this.TXTS2);
            this.Controls.Add(this.TXTS1);
            this.Controls.Add(this.CMBDERS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSınavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSınavNotlar";
            this.Load += new System.EventHandler(this.FrmSınavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CMBDERS;
        private System.Windows.Forms.TextBox TXTS1;
        private System.Windows.Forms.TextBox TXTS2;
        private System.Windows.Forms.TextBox TXTS3;
        private System.Windows.Forms.TextBox TXTPROJE;
        private System.Windows.Forms.TextBox TXTORT;
        private System.Windows.Forms.TextBox TXTDURUM;
        private System.Windows.Forms.Button btntemzle;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnara;
    }
}