using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Uye_Ol_Guvenlik : Form
    {
        public FrmMRS_Uye_Ol_Guvenlik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        private void FrmMRS_Uye_Ol_Guvenlik_Load(object sender, EventArgs e)
        {
            List<Guvenlik> securities = new List<Guvenlik>();

            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM Security", baglanti);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {

                securities.Add(

                    new Guvenlik
                    {

                        Id = okuyucu.GetInt32(0),

                        Soru = okuyucu.GetString(1)

                    }

                    );

            }

            cbxGuvenlikSorusu.ValueMember = "Id";
            cbxGuvenlikSorusu.DisplayMember = "Soru";

            cbxGuvenlikSorusu.DataSource = securities;

            baglanti.Close();
        }

        int sayac = 0;

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            sayac = 0;

            if (string.IsNullOrWhiteSpace(txtParola.Text))
            {

                errorProvider.SetError(txtParola, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                if (txtParola.TextLength < 12)
                {

                    errorProvider.SetError(txtParola, "Parola en az 12 haneli olmalıdır");

                    sayac++;

                }
                else
                {

                    errorProvider.Clear();

                }

            }

            if (string.IsNullOrWhiteSpace(txtParolaOnay.Text))
            {

                errorProvider2.SetError(txtParolaOnay, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                if (txtParola.Text != txtParolaOnay.Text)
                {

                    errorProvider2.SetError(txtParolaOnay, "Parola uyuşmazlığı");

                    sayac++;

                }
                else
                {

                    errorProvider2.Clear();

                    FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi.Parola = txtParolaOnay.Text;

                }

            }

            FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi.Guvevlik = (Guvenlik)cbxGuvenlikSorusu.SelectedItem;

            if (string.IsNullOrWhiteSpace(txtGuvenlikSorusuCevap.Text))
            {

                errorProvider3.SetError(txtGuvenlikSorusuCevap, "Boş bırakılamaz");

                sayac++;

            }
            else
            {

                errorProvider3.Clear();

                FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi.Cevap = txtGuvenlikSorusuCevap.Text;

            }

            if (sayac == 0)
            {

                Kisi kisi = FrmMRS_Uye_Ol_Kimlik_Bilgileri.kisi;

                baglanti.Open();

                komut = new SqlCommand("INSERT INTO Person(IdentityNo, Name, Surname, GenderId, DateOfBirth, PlaceOfBirth, FatherName, MotherName, TelephoneNo, Email, Password, SecurityId, Answer) VALUES (@IdentityNo, @Name, @Surname, @GenderId, @DateOfBirth, @PlaceOfBirth, @FatherName, @MotherName, @TelephoneNo, @Email, @Password, @SecurityId, @Answer)", baglanti);

                komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);
                komut.Parameters.AddWithValue("@Name", kisi.Ad);
                komut.Parameters.AddWithValue("@Surname", kisi.Soyad);
                komut.Parameters.AddWithValue("@GenderId", kisi.Cinsiyet.Id);
                komut.Parameters.AddWithValue("@DateOfBirth", kisi.DogumYili);
                komut.Parameters.AddWithValue("@PlaceOfBirth", kisi.DogumYeri);
                komut.Parameters.AddWithValue("@FatherName", kisi.BabaAd);
                komut.Parameters.AddWithValue("@MotherName", kisi.AnneAd);
                komut.Parameters.AddWithValue("@TelephoneNo", kisi.TelefonNo);
                komut.Parameters.AddWithValue("@Email", kisi.Eposta);
                komut.Parameters.AddWithValue("@Password", kisi.Parola);
                komut.Parameters.AddWithValue("@SecurityId", kisi.Guvevlik.Id);
                komut.Parameters.AddWithValue("@Answer", kisi.Cevap);

                int result = komut.ExecuteNonQuery();

                if (result > 0)
                {

                    if (MessageBox.Show("Sisteme kaydınız başarıyla gerçekleşmiştir. Giriş yapmak ister misiniz?", "Üye Ol", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();

                        FrmMRS frmMRS = new FrmMRS();

                        frmMRS.Visible = true;

                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                baglanti.Close();

            }
        }

        private void txtGuvenlikSorusuCevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;

            }
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


    }
}
