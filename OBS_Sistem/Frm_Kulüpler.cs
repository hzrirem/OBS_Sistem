using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OBS_Sistem
{
    public partial class Frm_Kulüpler : Form
    {
        public Frm_Kulüpler()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBC1R06;Initial Catalog=Okul_obs;Integrated Security=True");

       public void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_kulupler", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Frm_Kulüpler_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_kulupler(ad)values(@p1)",sqlConnection);
            komut.Parameters.AddWithValue("@p1", TXTKULÜPAD.Text);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp Listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTKULÜPAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_kulupler where ıd=@p1", sqlConnection);
            komut.Parameters.AddWithValue("@p1", TXTID.Text);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp silme işlemi başarıyla tamamlandı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("update tbl_kulupler set ad=@p1 where ıd=@p2", sqlConnection);
            komut.Parameters.AddWithValue("@p1", TXTKULÜPAD.Text);
            komut.Parameters.AddWithValue("@p2", TXTID.Text);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp güncelleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
    }
}
