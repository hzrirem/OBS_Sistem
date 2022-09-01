using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Sistem
{
    public partial class FrmOgrenciİsleri : Form
    {
        public FrmOgrenciİsleri()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBC1R06;Initial Catalog=Okul_obs;Integrated Security=True");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenciİsleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListesi();


            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_kulupler",sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulüp.DisplayMember = "Ad";
            cmbkulüp.ValueMember = "Id";
            cmbkulüp.DataSource = dt;
            sqlConnection.Close();
        }
        string c = " ";
        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciEkle(TXTAD.Text,TXTSOYAD.Text,byte.Parse(cmbkulüp.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Eklendi.");

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListesi();    
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            ds.Güncelle(TXTAD.Text, TXTSOYAD.Text, byte.Parse(cmbkulüp.Text.ToString()), c, int.Parse(TXTID.Text));
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            ds.Sİl(int.Parse(TXTID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void RDBKIZ_CheckedChanged(object sender, EventArgs e)
        {
            if (RDBKIZ.Checked)
            {
                c = "Kız";
            }
            if (RDBERKEK.Checked)
            {
                c = "Erkek";
            }
        }

        private void RDBERKEK_CheckedChanged(object sender, EventArgs e)
        {
            if (RDBKIZ.Checked)
            {
                c = "Kız";
            }
            if (RDBERKEK.Checked)
            {
                c = "Erkek";
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource =ds.ÖğrenciGetir(txtara.Text);


        }
    }
}
