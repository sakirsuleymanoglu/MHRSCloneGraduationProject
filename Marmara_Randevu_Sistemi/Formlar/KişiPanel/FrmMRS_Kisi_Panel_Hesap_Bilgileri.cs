using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Kisi_Panel_Hesap_Bilgileri : Form
    {
        public FrmMRS_Kisi_Panel_Hesap_Bilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        Kisi kisi;

        private void FrmMRS_Kisi_Panel_Hesap_Bilgileri_Load(object sender, EventArgs e)
        {
            List<Guvenlik> guvenlikSorulari = new List<Guvenlik>();

            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM Security", baglanti);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                guvenlikSorulari.Add(
                   new Guvenlik
                   {
                       Id = okuyucu.GetInt32(0),
                       Soru = okuyucu.GetString(1)
                   }
                   );
            }

            cbxGuvenlikSorusu.ValueMember = "Id";
            cbxGuvenlikSorusu.DisplayMember = "Soru";
            cbxGuvenlikSorusu.DataSource = guvenlikSorulari;

            baglanti.Close();

            kisi = FrmMRS.kisi;

            lblKimlikNo.Text = kisi.KimlikNo;
            lblAd.Text = kisi.Ad;
            lblSoyad.Text = kisi.Soyad;
            lblCinsiyet.Text = kisi.Cinsiyet.Cins;
            DateTime dateOfBirth = kisi.DogumYili;
            lblDogumYili.Text = dateOfBirth.ToString("dd.MM.yyyy");
            lblDogumYeri.Text = kisi.DogumYeri;
            lblBabaAd.Text = kisi.BabaAd;
            lblAnneAd.Text = kisi.AnneAd;
            txtTelefonNo.Text = kisi.TelefonNo;
            txtEposta.Text = kisi.Eposta;
            lblSoru.Text = kisi.Guvevlik.Soru;
            lblCevap.Text = kisi.Cevap;
        }

        private void pbxKapat_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmMRS_Kisi_Panel frmMRS_Person_Panel = new FrmMRS_Kisi_Panel();

            frmMRS_Person_Panel.Visible = true;
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



        int iletisimKaydetSayac = 0;

        private void btnIletisimKaydet_Click(object sender, EventArgs e)
        {
            iletisimKaydetSayac = 0;

            if (string.IsNullOrWhiteSpace(txtTelefonNo.Text))
            {
                errorProvider.SetError(txtTelefonNo, "Boş bırakılamaz");

                iletisimKaydetSayac++;
            }
            else
            {
                if (txtTelefonNo.TextLength < 11)
                {
                    errorProvider.SetError(txtTelefonNo, "Cep Telefonu 11 haneli olmalıdır");

                    iletisimKaydetSayac++;
                }
                else
                {
                    errorProvider.Clear();
                }
            }

            if (string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                errorProvider2.SetError(txtEposta, "Boş bırakılamaz");

                iletisimKaydetSayac++;
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

                    iletisimKaydetSayac++;
                }
                else
                {
                    errorProvider2.Clear();
                }
            }

            if (iletisimKaydetSayac == 0)
            {
                baglanti.Open();

                kisi.TelefonNo = txtTelefonNo.Text;

                kisi.Eposta = txtEposta.Text;

                komut = new SqlCommand("UPDATE Person SET TelephoneNo = @TelephoneNo, Email = @Email WHERE IdentityNo = @IdentityNo", baglanti);

                komut.Parameters.AddWithValue("@TelephoneNo", kisi.TelefonNo);
                komut.Parameters.AddWithValue("@Email", kisi.Eposta);
                komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Cep Telefonu ve E-Posta Adresi başarıyla kaydedildi", "Hesap Bilgilerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglanti.Close();
            }
        }

        int parolaKaydetSayac = 0;

        private void btnParolaKaydet_Click(object sender, EventArgs e)
        {
            parolaKaydetSayac = 0;

            if (string.IsNullOrWhiteSpace(txtParola.Text))
            {
                errorProvider3.SetError(txtParola, "Boş bırakılamaz");
                parolaKaydetSayac++;
            }
            else
            {
                if (txtParola.TextLength < 12)
                {
                    errorProvider3.SetError(txtParola, "Parola en az 12 haneli olmalıdır");

                    parolaKaydetSayac++;
                }
                else
                {
                    errorProvider3.Clear();
                }
            }

            if (string.IsNullOrWhiteSpace(txtParolaOnay.Text))
            {
                errorProvider4.SetError(txtParolaOnay, "Boş bırakılamaz");

                parolaKaydetSayac++;
            }
            else
            {
                if (txtParola.Text != txtParolaOnay.Text)
                {
                    errorProvider4.SetError(txtParolaOnay, "Parola uyuşmazlığı");

                    parolaKaydetSayac++;
                }
                else
                {
                    errorProvider4.Clear();
                }
            }

            if (parolaKaydetSayac == 0)
            {
                baglanti.Open();

                kisi.Parola = txtParolaOnay.Text;

                komut = new SqlCommand("UPDATE Person SET Password = @Password WHERE IdentityNo = @IdentityNo", baglanti);

                komut.Parameters.AddWithValue("@Password", kisi.Parola);
                komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Parola başarıyla kaydedildi", "Hesap Bilgilerim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtParola.Clear();

                    txtParolaOnay.Clear();
                }

                baglanti.Close();
            }
        }

        int guvenlikKaydetSayac = 0;

        private void btnGuvenlikKaydet_Click(object sender, EventArgs e)
        {
            guvenlikKaydetSayac = 0;

            if (string.IsNullOrWhiteSpace(txtGuvenlikSorusuCevap.Text))
            {
                errorProvider5.SetError(txtGuvenlikSorusuCevap, "Boş bırakılamaz");

                guvenlikKaydetSayac++;
            }
            else
            {
                errorProvider5.Clear();
            }

            if (guvenlikKaydetSayac == 0)
            {
                baglanti.Open();

                kisi.Guvevlik = (Guvenlik)cbxGuvenlikSorusu.SelectedItem;

                kisi.Cevap = txtGuvenlikSorusuCevap.Text;

                komut = new SqlCommand("UPDATE Person SET SecurityId = @SecurityId, Answer = @Answer WHERE IdentityNo = @IdentityNo", baglanti);

                komut.Parameters.AddWithValue("@SecurityId", kisi.Guvevlik.Id);
                komut.Parameters.AddWithValue("@Answer", kisi.Cevap);
                komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Güvenlik Sorusu ve Cevap başarıyla kaydedildi", "Hesap Bilgilerim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblSoru.Text = kisi.Guvevlik.Soru;

                    lblCevap.Text = kisi.Cevap;
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
    }
}
