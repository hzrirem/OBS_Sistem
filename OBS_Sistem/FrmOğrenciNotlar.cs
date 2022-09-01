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
    public partial class FrmOğrenciNotlar : Form
    {
        public FrmOğrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBC1R06;Initial Catalog=Okul_obs;Integrated Security=True");

        public string numara;


        private void FrmOğrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select ad,sınav1,sınav2,sınav3,proje,ortalama,durum from tbl_notlar inner join tbl_dersler on tbl_notlar.dersıd = tbl_dersler.ıd where ogrıd=@p1",sqlConnection);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
