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
namespace Proje_Hastane
{
    public partial class FrmDoktorGırıs : Form
    {
        public FrmDoktorGırıs()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl =new sqlbaglantisi();
        private void BtngırısYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from TBL_Doktorlar where DoktorTC=@p1 and DoktorSıfre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.Tc=MskTC.Text;
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();

        }

        
    }
}
