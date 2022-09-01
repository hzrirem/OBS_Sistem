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
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds =new DataSet1TableAdapters.Tbl_NotlarTableAdapter(); 
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBC1R06;Initial Catalog=Okul_obs;Integrated Security=True");

        int notid;
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(TXTID.Text));

        }
       

        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            


            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_dersler", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CMBDERS.DisplayMember = "Ad";
            CMBDERS.ValueMember = "Id";
            CMBDERS.DataSource = dt;
            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTS1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTS2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTS3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXTPROJE.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); 
            TXTORT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); 
            TXTDURUM.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int s1, s2, s3, proje;
        double ort;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
         
            //string durum;
            s1 = Convert.ToInt32(TXTS1.Text);
            s2 = Convert.ToInt32(TXTS2.Text);
            s3 = Convert.ToInt32(TXTS3.Text);
            proje = Convert.ToInt32(TXTPROJE.Text);

            ort = (s1 + s2 + s3 + proje) / 4;
            TXTORT.Text = ort.ToString();

            if (ort>=50)
            {
                TXTDURUM.Text = "True";
            }
            else
            {
                TXTDURUM.Text = "False";
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            ds.NotGüncelle(byte.Parse(CMBDERS.SelectedValue.ToString()), int.Parse(TXTID.Text), byte.Parse(TXTS1.Text), byte.Parse(TXTS2.Text), byte.Parse(TXTS3.Text), byte.Parse(TXTPROJE.Text), byte.Parse(TXTORT.Text), bool.Parse(TXTDURUM.Text), notid);
        }
    }
}
