using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Sistem
{
    public partial class FrmDersİslemleri : Form
    {
        public FrmDersİslemleri()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void FrmDersİslemleri_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            ds.DersEkle(TXTDERSAD.Text);
            MessageBox.Show("Ders ekleme işlemi gerçekleştirilmiştir.");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(TXTDERSAD.Text,byte.Parse(TXTID.Text));
            MessageBox.Show("Ders Güncellendi.");
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(TXTID.Text));
            MessageBox.Show("Ders silindi.");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTDERSAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
