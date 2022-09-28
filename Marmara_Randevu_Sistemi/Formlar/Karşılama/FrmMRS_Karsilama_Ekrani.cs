using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi.Formlar.Karşılama
{
    public partial class FrmMRS_Karsilama_Ekrani : Form
    {
        public FrmMRS_Karsilama_Ekrani()
        {
            InitializeComponent();
        }

        private void FrmMRS_Karsilama_Ekrani_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblKullanici.Text = FrmMRS.kisi.Ad + " " + FrmMRS.kisi.Soyad;
            prbYonlendirme.Value = 0;
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 3 == 0)
            {
                lblYonlendirme.Text = "Yönlendiriliyorsunuz.";
            }
            else
            {
                lblYonlendirme.Text += ".";
            }

            if (sayac == 5)
            {
                timer1.Stop();
                FrmMRS_Kisi_Panel frmMRS_Kisi_Panel = new
                    FrmMRS_Kisi_Panel();
                frmMRS_Kisi_Panel.Show();
                this.Close();
            }

            prbYonlendirme.Value += 20;
        }
    }
}
