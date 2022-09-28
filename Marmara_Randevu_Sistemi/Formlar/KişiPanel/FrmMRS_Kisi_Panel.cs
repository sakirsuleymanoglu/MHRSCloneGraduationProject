using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Kisi_Panel : Form
    {
        public FrmMRS_Kisi_Panel()
        {
            InitializeComponent();
        }

        private void FrmMRS_Kisi_Panel_Load(object sender, EventArgs e)
        {
            Kisi kisi = FrmMRS.kisi;

            lblAdSoyad.Text = "Sn. " + kisi.Ad + " " + kisi.Soyad;
        }

        private void pbxCikis_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmMRS frmMRS = new FrmMRS();

            frmMRS.Visible = true;
        }

        private void btnHesapBilgileri_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmMRS_Kisi_Panel_Hesap_Bilgileri frmMRS_Kisi_Panel_Hesap_Bilgileri = new FrmMRS_Kisi_Panel_Hesap_Bilgileri();

            frmMRS_Kisi_Panel_Hesap_Bilgileri.Show();
        }

        private void btnRandevuGecmisi_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmMRS_Kisi_Panel_Randevu_Gecmisi frmMRS_Kisi_Panel_Randevu_Gecmisi = new FrmMRS_Kisi_Panel_Randevu_Gecmisi();

            frmMRS_Kisi_Panel_Randevu_Gecmisi.Show();
        }

        private void btnRandevuTalepleri_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmMRS_Kisi_Panel_Randevu_Talepleri frmMRS_Kisi_Panel_Randevu_Talepleri = new FrmMRS_Kisi_Panel_Randevu_Talepleri();

            frmMRS_Kisi_Panel_Randevu_Talepleri.Show();
        }

        private void btnHastaneRandevuAl_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmMRS_Kisi_Panel_Hastane_Randevu_Alma frmMRS_Kisi_Panel_Hastane_Randevu_Alma = new FrmMRS_Kisi_Panel_Hastane_Randevu_Alma();

            frmMRS_Kisi_Panel_Hastane_Randevu_Alma.Show();
        }

        private void pbxCikis_MouseHover(object sender, EventArgs e)
        {
            pbxCikis.SetBounds(pbxCikis.Location.X, pbxCikis.Location.Y, 35, 35);

            pbxCikis.ImageLocation = @"C:\Users\sakir\source\repos\MRS\icons\exit_red.png";
        }

        private void pbxCikis_MouseLeave(object sender, EventArgs e)
        {
            pbxCikis.SetBounds(pbxCikis.Location.X, pbxCikis.Location.Y, 32, 32);

            pbxCikis.ImageLocation = @"C:\Users\sakir\source\repos\MRS\icons\exit_white.png";
        }
    }
}
