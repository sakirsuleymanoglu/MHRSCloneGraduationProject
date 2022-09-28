using System;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Uye_Ol_Iletisim_Bilgileri : Form
    {
        public FrmMRS_Uye_Ol_Iletisim_Bilgileri()
        {
            InitializeComponent();
        }

        private void FrmMRS_Uye_Ol_Iletisim_Bilgileri_Load(object sender, EventArgs e)
        {

        }

        private void pbxKapat_Click(object sender, EventArgs e)
        {

            this.Close();

            FrmMRS frmMRS = new FrmMRS();

            frmMRS.Visible = true;
        }

        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;

            }
        }

        private void pbxSonrakiSayfa_MouseHover(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 35, 35);

        }

        private void pbxSonrakiSayfa_MouseLeave(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 32, 32);
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

        int sayac = 0;

        private void pbxSonrakiSayfa_Click(object sender, EventArgs e)
        {
            sayac = 0;

            if (string.IsNullOrWhiteSpace(txtTelefonNo.Text))
            {

                errorProvider.SetError(txtTelefonNo, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                if (txtTelefonNo.TextLength < 11)
                {

                    errorProvider.SetError(txtTelefonNo, "Cep Telefon No 11 haneli olmalıdır");

                    sayac++;

                }
                else
                {

                    errorProvider.Clear();

                    FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi.TelefonNo = txtTelefonNo.Text;

                }
            }

            if (string.IsNullOrWhiteSpace(txtEposta.Text))
            {

                errorProvider2.SetError(txtEposta, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                string emailControl = txtEposta.Text;

                int indexOfAltQ, indexOfCom, indexOfEdu;

                indexOfAltQ = emailControl.IndexOf('@');
                indexOfCom = emailControl.IndexOf(".com");
                indexOfEdu = emailControl.IndexOf(".edu.tr");

                if (!((indexOfAltQ > 0 && indexOfCom > 0) || (indexOfAltQ > 0 && indexOfEdu > 0)))
                {

                    errorProvider2.SetError(txtEposta, "E-Posta tipinde bir giriş yapın");

                    sayac++;

                }
                else
                {

                    errorProvider2.Clear();

                }

            }

            if (string.IsNullOrWhiteSpace(txtEpostaOnay.Text))
            {

                errorProvider3.SetError(txtEpostaOnay, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                if (txtEposta.Text != txtEpostaOnay.Text)
                {

                    errorProvider3.SetError(txtEpostaOnay, "E-Posta uyuşmazlığı");

                    sayac++;

                }
                else
                {

                    errorProvider3.Clear();

                    FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi.Eposta = txtEpostaOnay.Text;

                }
            }

            if (sayac == 0)
            {

                FrmMRS_Uye_Ol_Guvenlik frmMRS_Register_Security = new FrmMRS_Uye_Ol_Guvenlik();

                frmMRS_Register_Security.Show();

                this.Close();

            }

        }
    }
}
