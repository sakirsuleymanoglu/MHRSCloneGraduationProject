using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Kisi_Panel_Randevu_Talepleri : Form
    {
        public FrmMRS_Kisi_Panel_Randevu_Talepleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        Kisi kisi = FrmMRS.kisi;

        private void FrmMRS_Kisi_Panel_Randevu_Talepleri_Load(object sender, EventArgs e)
        {
            dgwRandevuTalepleri.AllowUserToAddRows = false;
            dgwRandevuTalepleri.AllowUserToDeleteRows = false;
            dgwRandevuTalepleri.ReadOnly = true;
            dgwRandevuTalepleri.AllowUserToResizeColumns = false;
            dgwRandevuTalepleri.AllowUserToResizeRows = false;

            btnIptalEt.Enabled = false;

            baglanti.Open();

            komut = new SqlCommand("SELECT Appointment.Id, Appointment_Person.GetDate [Randevu Alım Tarihi], Doctor.Name + ' ' + Doctor.Surname [Doktor], Clinic.Name [Klinik], Hospital.Name [Kurum], District.Name [İlçe], City.Name [İl] FROM Appointment JOIN Appointment_Person ON Appointment.Id = Appointment_Person.AppointmentId JOIN Person ON Person.Id = Appointment_Person.PersonId JOIN Doctor ON Doctor.Id = Appointment.DoctorId JOIN Clinic ON Clinic.Id = Doctor.ClinicId JOIN Hospital ON Hospital.Id = Clinic.HospitalId JOIN District ON District.Id = Hospital.DistrictId JOIN City ON City.Id = District.CityId Where EnableState = 1 and Appointment.DateTime > GetDate() and Person.Id = @PersonId", baglanti);

            komut.Parameters.AddWithValue("@PersonId", kisi.Id);

            okuyucu = komut.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(okuyucu);

            dgwRandevuTalepleri.DataSource = dataTable;

            baglanti.Close();

            dgwRandevuTalepleri.Columns["Id"].Visible = false;

            dgwRandevuTalepleri.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dgwRandevuTalepleri.DefaultCellStyle.SelectionForeColor = Color.White;
        }


        private void btnYenile_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new SqlCommand("SELECT Appointment.Id, Appointment_Person.GetDate [Randevu Alım Tarihi], Doctor.Name + ' ' + Doctor.Surname [Doktor], Clinic.Name [Klinik], Hospital.Name [Kurum], District.Name [İlçe], City.Name [İl] FROM Appointment JOIN Appointment_Person ON Appointment.Id = Appointment_Person.AppointmentId JOIN Person ON Person.Id = Appointment_Person.PersonId JOIN Doctor ON Doctor.Id = Appointment.DoctorId JOIN Clinic ON Clinic.Id = Doctor.ClinicId JOIN Hospital ON Hospital.Id = Clinic.HospitalId JOIN District ON District.Id = Hospital.DistrictId JOIN City ON City.Id = District.CityId Where EnableState = 1 and Appointment.DateTime > GetDate() and Person.Id = @PersonId", baglanti);

            komut.Parameters.AddWithValue("@PersonId", kisi.Id);

            okuyucu = komut.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(okuyucu);

            dgwRandevuTalepleri.DataSource = dataTable;

            baglanti.Close();

            dgwRandevuTalepleri.Columns["Id"].Visible = false;

            dgwRandevuTalepleri.ClearSelection();
        }


        int randevuId;

        private void dgwRandevuTalepleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwRandevuTalepleri.DefaultCellStyle.SelectionBackColor = Color.FromArgb(78, 184, 206);
            dgwRandevuTalepleri.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 50, 56); ;

            btnIptalEt.Enabled = true;

            int index = dgwRandevuTalepleri.CurrentCell.RowIndex;

            randevuId = Convert.ToInt32(dgwRandevuTalepleri.Rows[index].Cells[0].Value);
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            komut = new SqlCommand("UPDATE Appointment SET EnableState = 0 Where Appointment.Id = @AppointmentId", baglanti);

            komut.Parameters.AddWithValue("@AppointmentId", randevuId);


            int sonuc = 0;

            if (MessageBox.Show("Randevu iptal ediliyor, onaylıyor musunuz?", "Randevu Taleplerim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sonuc = komut.ExecuteNonQuery();
            }

            if (sonuc == 1)
            {

                MessageBox.Show("Randevunuz başarıyla iptal edildi", "Randevu Taleplerim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIptalEt.Enabled = false;

            }

            baglanti.Close();
        }



        private void pbxClose_Click(object sender, EventArgs e)
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
    }
}

