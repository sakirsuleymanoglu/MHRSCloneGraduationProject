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
using Marmara_Randevu_Sistemi.Formlar.Karşılama;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS : Form
    {
        public FrmMRS()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        private void pbxKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxKimlik_Click(object sender, EventArgs e)
        {
            txtKimlikNo.Focus();
        }

        private void pbxParola_Click(object sender, EventArgs e)
        {
            txtParola.Focus();
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

        private void pbxS_Bakan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Türkiye Cumhuriyeti Sağlık Bakanlığı, Türkiye Cumhuriyeti Cumhurbaşkanlığına bağlı olarak çalışan, sağlık işlerinden sorumlu olan bakanlık.",
               "T.C. SAĞLIK BAKANLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblS_Bakan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Türkiye Cumhuriyeti Sağlık Bakanlığı, Türkiye Cumhuriyeti Cumhurbaşkanlığına bağlı olarak çalışan, sağlık işlerinden sorumlu olan bakanlık.",
              "T.C. SAĞLIK BAKANLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            FrmMRS_Uye_Ol_Kimlik_Bilgileri frmMRS_Uye_Ol_Kimlik_Bilgileri = new FrmMRS_Uye_Ol_Kimlik_Bilgileri();
            frmMRS_Uye_Ol_Kimlik_Bilgileri.Show();
            this.Visible = false;
        }

        private void btnHatirlamiyorum_Click(object sender, EventArgs e)
        {
            FrmMRS_Hatirlama frmMRS_Hatirlama = new FrmMRS_Hatirlama();
            frmMRS_Hatirlama.Show();
            this.Visible = false;
        }

        int sayac = 0;

        public static Kisi kisi;

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            sayac = 0;

            if (string.IsNullOrWhiteSpace(txtKimlikNo.Text))
            {
                sayac++;
                errorProvider.SetError(txtKimlikNo, "Boş bırakılamaz");
            }
            else
            {
                if (txtKimlikNo.TextLength < 11)
                {
                    sayac++;
                    errorProvider.SetError(txtKimlikNo, "T.C. Kimlik No 11 haneli olmalıdır");
                }
                else
                {
                    errorProvider.Clear();
                }
            }

            if (string.IsNullOrWhiteSpace(txtParola.Text))
            {
                sayac++;
                errorProvider2.SetError(txtParola, "Boş bırakılamaz");
            }
            else
            {
                if (txtParola.TextLength < 12)
                {
                    errorProvider2.SetError(txtParola, "Parola en az 12 haneli olmalıdır");
                    sayac++;
                }
                else
                {
                    errorProvider2.Clear();
                    if (sayac == 0)
                    {
                        baglanti.Open();
                        komut = new SqlCommand("SELECT * FROM Person WHERE IdentityNo = @IdentityNo", baglanti);
                        komut.Parameters.AddWithValue("@IdentityNo", txtKimlikNo.Text);
                        okuyucu = komut.ExecuteReader();
                        if (!okuyucu.Read())
                        {
                            MessageBox.Show("Sistemde kaydınız bulunmamaktadır", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            sayac++;
                        }
                        baglanti.Close();
                    }
                }
            }

            if (sayac == 0)
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT Person.Id, Person.IdentityNo, Person.Name, Person.Surname, Person.GenderId, Gender.Name, Person.DateOfBirth, Person.PlaceOfBirth, Person.FatherName, Person.MotherName, Person.TelephoneNo, Person.Email, Person.SecurityId, Security.Question, Person.Answer FROM Person, Security, Gender WHERE Person.SecurityId = Security.Id AND Person.GenderId = Gender.Id and IdentityNo = @IdentityNo and Password = @Password", baglanti);
                komut.Parameters.AddWithValue("@IdentityNo", txtKimlikNo.Text);
                komut.Parameters.AddWithValue("@Password", txtParola.Text);
                okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    kisi = new Kisi
                    {
                        Id = okuyucu.GetInt32(0),
                        KimlikNo = okuyucu.GetString(1),
                        Ad = okuyucu.GetString(2),
                        Soyad = okuyucu.GetString(3),
                        Cinsiyet = new Cinsiyet
                        {
                            Id = okuyucu.GetInt32(4),
                            Cins = okuyucu.GetString(5)
                        },
                        DogumYili = okuyucu.GetDateTime(6),
                        DogumYeri = okuyucu.GetString(7),
                        BabaAd = okuyucu.GetString(8),
                        AnneAd = okuyucu.GetString(9),
                        TelefonNo = okuyucu.GetString(10),
                        Eposta = okuyucu.GetString(11),
                        Guvevlik = new Guvenlik
                        {
                            Id = okuyucu.GetInt32(12),
                            Soru = okuyucu.GetString(13)
                        },
                        Cevap = okuyucu.GetString(14)
                    };
                    FrmMRS_Karsilama_Ekrani frmMRS_Karsilama_Ekrani = new FrmMRS_Karsilama_Ekrani();
                    frmMRS_Karsilama_Ekrani.Show();

                   /* FrmMRS_Kisi_Panel frmMRS_Kisi_Panel = new FrmMRS_Kisi_Panel();
                    frmMRS_Kisi_Panel.Show();*/
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Parolanız yanlış, tekrar deneyiniz", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
        }

        private void txtKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar))
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
