using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Hatirlama : Form
    {
        public FrmMRS_Hatirlama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

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

        private void pbxSonrakiSayfa_MouseHover(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 35, 35);
        }

        private void pbxSonrakiSayfa_MouseLeave(object sender, EventArgs e)
        {
            pbxSonrakiSayfa.SetBounds(pbxSonrakiSayfa.Location.X, pbxSonrakiSayfa.Location.Y, 32, 32);
        }

        int sayac = 0;

        public static Kisi kisi = new Kisi();

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
                }
            }

            if (string.IsNullOrWhiteSpace(txtDogumYeri.Text))
            {
                errorProvider2.SetError(txtDogumYeri, "Boş bırakılamaz");

                sayac++;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtBabaAd.Text))
            {
                errorProvider3.SetError(txtBabaAd, "Boş bırakılamaz");

                sayac++;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (sayac == 0)
            {
                baglanti.Open();

                kisi.KimlikNo = txtKimlikNo.Text;
                kisi.DogumYili = dtpcrDogumYili.Value;
                kisi.DogumYeri = txtDogumYeri.Text;
                kisi.BabaAd = txtBabaAd.Text;

                komut = new SqlCommand("SELECT Security.Id, Security.Question, Answer FROM Person, Security WHERE Person.SecurityId = Security.Id AND IdentityNo = @IdentityNo AND DateOfBirth = @DateOfBirth AND PlaceOfBirth = @PlaceOfBirth AND FatherName = @FatherName", baglanti);

                komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);
                komut.Parameters.AddWithValue("@DateOfBirth", kisi.DogumYili);
                komut.Parameters.AddWithValue("@PlaceOfBirth", kisi.DogumYeri);
                komut.Parameters.AddWithValue("@FatherName", kisi.BabaAd);

                okuyucu = komut.ExecuteReader();

                if (okuyucu.Read())
                {
                    kisi.Guvevlik = new Guvenlik
                    {
                        Id = okuyucu.GetInt32(0),
                        Soru = okuyucu.GetString(1)
                    };
                    kisi.Cevap = okuyucu.GetString(2);

                    FrmMRS_Hatirlama_Guvenlik_Sorusu frmMRS_Hatirlama_Guvenlik_Sorusu = new FrmMRS_Hatirlama_Guvenlik_Sorusu();

                    frmMRS_Hatirlama_Guvenlik_Sorusu.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz bilgileri gözden geçirin", "Hatırlamıyorum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
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

    }
}
