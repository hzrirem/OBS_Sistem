
namespace OBS_Sistem
{
    partial class FrmDersİslemleri
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
            this.BTNSİL = new System.Windows.Forms.Button();
            this.BTNGUNCELLE = new System.Windows.Forms.Button();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.TXTDERSAD = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSİL
            // 
            this.BTNSİL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSİL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSİL.Location = new System.Drawing.Point(218, 296);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(133, 45);
            this.BTNSİL.TabIndex = 19;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.UseVisualStyleBackColor = true;
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGUNCELLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGUNCELLE.Location = new System.Drawing.Point(218, 242);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(133, 45);
            this.BTNGUNCELLE.TabIndex = 18;
            this.BTNGUNCELLE.Text = "GÜNCELLE";
            this.BTNGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEKLE.Location = new System.Drawing.Point(41, 296);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(133, 45);
            this.BTNEKLE.TabIndex = 17;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistele.Location = new System.Drawing.Point(41, 242);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(133, 45);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // TXTDERSAD
            // 
            this.TXTDERSAD.Location = new System.Drawing.Point(124, 205);
            this.TXTDERSAD.Name = "TXTDERSAD";
            this.TXTDERSAD.Size = new System.Drawing.Size(155, 20);
            this.TXTDERSAD.TabIndex = 15;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(126, 170);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(153, 20);
            this.TXTID.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DERS ADI:";
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Location = new System.Drawing.Point(58, 173);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(54, 13);
            this.LABEL2.TabIndex = 12;
            this.LABEL2.Text = "DERS ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 105);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "DERS İŞLEMLERİ PANELİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(339, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Çıkış";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmDersİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNSİL);
            this.Controls.Add(this.BTNGUNCELLE);
            this.Controls.Add(this.BTNEKLE);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.TXTDERSAD);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDersİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDersİslemleri";
            this.Load += new System.EventHandler(this.FrmDersİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSİL;
        private System.Windows.Forms.Button BTNGUNCELLE;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox TXTDERSAD;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}