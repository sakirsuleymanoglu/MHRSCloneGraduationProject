using System;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Hatirlama_Guvenlik_Sorusu : Form
    {
        public FrmMRS_Hatirlama_Guvenlik_Sorusu()
        {
            InitializeComponent();
        }

        private void pbxKapat_MouseHover(object sender, EventArgs e)
        {
            pbxKapat.SetBounds(pbxKapat.Location.X, pbxKapat.Location.Y, 35, 35);

            pbxKapat.ImageLocation = @"C:\Users\sakir\source\repos\MRS\icons\close_red.png";
        }

        private void pbxKapat_MouseLeave(object sender, EventArgs e)
        {
            pbxKapat.SetBounds(pbxKapat.Location.X, pbxKapat.Location.Y, 32, 32);

            pbxKapat.ImageLocation = @"C:\Users\sakir\source\repos\MRS\icons\close_white.png";
        }

        private void pbxKapat_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmMRS frmMRS = new FrmMRS();

            frmMRS.Visible = true;
        }

        private void txtGuvenlikSorusuCevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void FrmMRS_Hatirlama_Guvenlik_Sorusu_Load(object sender, EventArgs e)
        {
            lblGuvenlikSorusu.Text = FrmMRS_Hatirlama.kisi.Guvevlik.Soru;
        }

        private void pbxSonrakiSayfa_MouseHover(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 35, 35);
        }

        private void pbxSonrakiSayfa_MouseLeave(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 32, 32);
        }

        int sayac = 0;

        private void pbxSonrakiSayfa_Click(object sender, EventArgs e)
        {
            sayac = 0;

            if (string.IsNullOrWhiteSpace(txtGuvenlikSorusuCevap.Text))
            {
                errorProvider.SetError(txtGuvenlikSorusuCevap, "Boş bırakılamaz");

                sayac++;
            }
            else
            {
                errorProvider.Clear();
            }

            if (sayac == 0)
            {
                if (FrmMRS_Hatirlama.kisi.Cevap == txtGuvenlikSorusuCevap.Text)
                {
                    FrmMRS_Hatirlama_Parola frmMRS_Hatirlama_Parola = new FrmMRS_Hatirlama_Parola();

                    frmMRS_Hatirlama_Parola.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz bilgileri gözden geçirin", "Hatırlamıyorum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
