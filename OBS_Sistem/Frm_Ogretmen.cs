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
    public partial class Frm_Ogretmen : Form
    {
        public Frm_Ogretmen()
        {
            InitializeComponent();
        }

        private void btnKulüp_Click(object sender, EventArgs e)
        {
            Frm_Kulüpler frm_Kulüpler = new Frm_Kulüpler();
            frm_Kulüpler.Show();
            

        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            FrmDersİslemleri frmDersİslemleri = new FrmDersİslemleri();
            frmDersİslemleri.Show();
            
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciİsleri frmOgrenciİsleri = new FrmOgrenciİsleri();
            frmOgrenciİsleri.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar frmSınavNotlar = new FrmSınavNotlar();
            frmSınavNotlar.Show();
        }
    }
}
