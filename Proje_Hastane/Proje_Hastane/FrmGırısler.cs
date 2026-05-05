using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGırısler : Form
    {
        public FrmGırısler()
        {
            InitializeComponent();
        }

        private void BtnHastaGırısı_Click(object sender, EventArgs e)
        {
            FrmHastaGırıs fr = new FrmHastaGırıs();
            fr.Show();
            this.Hide();//bu üstünde çalıştığım fotmu gizle fr nesnesınde tureyen formu getır
        }

        private void BtnDoktorGırısı_Click(object sender, EventArgs e)
        {
            FrmDoktorGırıs fr = new FrmDoktorGırıs();
            fr.Show();
            this.Hide();//bu üstünde çalıştığım fotmu gizle fr nesnesınde tureyen formu getır
        }

        private void BtnSekreterGırısı_Click(object sender, EventArgs e)
        {
            FrmSekreterGırıs fr = new FrmSekreterGırıs();
            fr.Show();
            this.Hide();//bu üstünde çalıştığım fotmu gizle fr nesnesınde tureyen formu getır
        }
    }
}
