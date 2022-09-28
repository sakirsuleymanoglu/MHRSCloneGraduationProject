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

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Uye_Ol_Kimlik_Bilgileri : Form
    {
        public FrmMRS_Uye_Ol_Kimlik_Bilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;
  
        public static Kisi kisi = new Kisi();

        private void FrmMRS_Uye_Ol_Kimlik_Bilgileri_Load(object sender, EventArgs e)
        {
            List<Cinsiyet> genders = new List<Cinsiyet>();

            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM Gender", baglanti);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {

                genders.Add(new Cinsiyet { Id = okuyucu.GetInt32(0), Cins = okuyucu.GetString(1) });

            }

            cbxCinsiyet.ValueMember = "Id";
            cbxCinsiyet.DisplayMember = "Cins";

            cbxCinsiyet.DataSource = genders;

            baglanti.Close();
        }

        private void pbxKapat_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmMRS frmMRS = new FrmMRS();

            frmMRS.Visible = true;
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

        private void pbxSonrakiSayfa_MouseHover(object sender, EventArgs e)
        {

            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 35, 35);
        }

        private void pbxSonrakiSayfa_MouseLeave(object sender, EventArgs e)
        {

            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 32, 32);
        }

        private void txtAnneAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBabaAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDogumYeri_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
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

        int sayac = 0;

        private void pbxSonrakiSayfa_Click(object sender, EventArgs e)
        {

            sayac = 0;

            if (string.IsNullOrWhiteSpace(txtKimlikNo.Text))
            {

                errorProvider.SetError(txtKimlikNo, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                if (txtKimlikNo.TextLength < 11)
                {

                    errorProvider.SetError(txtKimlikNo, "T.C. Kimlik No 11 haneli olmalıdır");

                    sayac++;

                }
                else
                {

                    errorProvider.Clear();

                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM PERSON WHERE IdentityNo = @IdentityNo", baglanti);

                    komut.Parameters.AddWithValue("@IdentityNo", txtKimlikNo.Text);

                    okuyucu = komut.ExecuteReader();

                }

            }

            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {

                errorProvider2.SetError(txtAd, "Boş bırakılamaz");

                sayac++;

            }
            else
            {
                kisi.Ad = txtAd.Text;

                errorProvider2.Clear();

            }

            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {

                errorProvider3.SetError(txtSoyad, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                kisi.Soyad = txtSoyad.Text;

                errorProvider3.Clear();

            }

            kisi.Cinsiyet = (Cinsiyet)cbxCinsiyet.SelectedItem;

            kisi.DogumYili = dtpcrDogumYili.Value;

            if (string.IsNullOrWhiteSpace(txtDogumYeri.Text))
            {

                errorProvider4.SetError(txtDogumYeri, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                errorProvider4.Clear();

                kisi.DogumYeri = txtDogumYeri.Text;

            }

            if (string.IsNullOrWhiteSpace(txtBabaAd.Text))
            {

                errorProvider5.SetError(txtBabaAd, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                errorProvider5.Clear();

                kisi.BabaAd = txtBabaAd.Text;

            }

            if (string.IsNullOrWhiteSpace(txtAnneAd.Text))
            {

                errorProvider6.SetError(txtAnneAd, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                errorProvider6.Clear();

                kisi.AnneAd = txtAnneAd.Text;

            }

            if (sayac == 0)
            {

                if (okuyucu.Read())
                {

                    MessageBox.Show("Sistemde kaydınız bulunmaktadır, eğer parolanızı hatırlamıyorsanız \"Hatırlamıyorum\" butonuna basarak parolanızı sıfırlayabiliriz.", "Üye Ol", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    sayac++;

                }
                else
                {

                    kisi.KimlikNo = txtKimlikNo.Text;

                    FrmMRS_Uye_Ol_Iletisim_Bilgileri frmMRS_Register_Contact = new FrmMRS_Uye_Ol_Iletisim_Bilgileri();

                    frmMRS_Register_Contact.Show();

                    this.Close();

                }
            }

            baglanti.Close();

        }
    }
}
