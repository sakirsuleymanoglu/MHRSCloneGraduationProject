using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Kisi_Panel_Randevu_Gecmisi : Form
    {
        public FrmMRS_Kisi_Panel_Randevu_Gecmisi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        private void FrmMRS_Kisi_Panel_Randevu_Gecmisi_Load(object sender, EventArgs e)
        {
            Kisi kisi = FrmMRS.kisi;

            dgwRandevuGecmisi.AllowUserToAddRows = false;
            dgwRandevuGecmisi.AllowUserToDeleteRows = false;
            dgwRandevuGecmisi.ReadOnly = true;
            dgwRandevuGecmisi.AllowUserToResizeColumns = false;
            dgwRandevuGecmisi.AllowUserToResizeRows = false;

            baglanti.Open();

            komut = new SqlCommand("SELECT Appointment_Person.GetDate [Randevu Alım Tarihi], Doctor.Name + ' ' + Doctor.Surname [Doktor], Clinic.Name [Klinik], Hospital.Name [Kurum], District.Name [İlçe], City.Name [İl] FROM Appointment JOIN Appointment_Person ON Appointment.Id = Appointment_Person.AppointmentId JOIN Person ON Person.Id = Appointment_Person.PersonId JOIN Doctor ON Doctor.Id = Appointment.DoctorId JOIN Clinic ON Clinic.Id = Doctor.ClinicId JOIN Hospital ON Hospital.Id = Clinic.HospitalId JOIN District ON District.Id = Hospital.DistrictId JOIN City ON City.Id = District.CityId Where EnableState = 0 or Appointment.DateTime < GetDate() and Person.Id = @PersonId", baglanti);

            komut.Parameters.AddWithValue("@PersonId", kisi.Id);

            okuyucu = komut.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(okuyucu);

            dgwRandevuGecmisi.DataSource = dataTable;

            baglanti.Close();

            dgwRandevuGecmisi.ClearSelection();
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

    }
}
