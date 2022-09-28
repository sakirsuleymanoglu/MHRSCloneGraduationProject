using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Hatirlama_Parola : Form
    {
        public FrmMRS_Hatirlama_Parola()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

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

        int sayac = 0;

        private void btnParolaKaydet_Click(object sender, EventArgs e)
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
                    FrmMRS_Hatirlama.kisi.Parola = txtParolaOnay.Text;

                    Kisi kisi = FrmMRS_Hatirlama.kisi;

                    errorProvider2.Clear();

                    baglanti.Open();

                    komut = new SqlCommand("UPDATE Person SET Password = @Password WHERE IdentityNo = @IdentityNo", baglanti);

                    komut.Parameters.AddWithValue("@Password", kisi.Parola);
                    komut.Parameters.AddWithValue("@IdentityNo", kisi.KimlikNo);

                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc == 1)
                    {
                        if (MessageBox.Show("Şifreniz başarıyla kaydedildi", "Hatırlamıyorum", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();

                            FrmMRS frmMRS = new FrmMRS();

                            frmMRS.Visible = true;
                        }
                    }

                    baglanti.Close();
                }
            }
        }

        private void FrmMRS_Hatirlama_Parola_Load(object sender, EventArgs e)
        {

        }
    }
}
