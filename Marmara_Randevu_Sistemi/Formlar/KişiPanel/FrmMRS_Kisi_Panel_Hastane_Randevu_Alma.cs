using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marmara_Randevu_Sistemi
{
    public partial class FrmMRS_Kisi_Panel_Hastane_Randevu_Alma : Form
    {
        public FrmMRS_Kisi_Panel_Hastane_Randevu_Alma()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RCE6ARO\SQLEXPRESS;Initial Catalog=MRS; Integrated Security=true");

        SqlCommand komut;

        SqlDataReader okuyucu;

        private void FrmMRS_Kisi_Panel_Hastane_Randevu_Alma_Load(object sender, EventArgs e)
        {
            lblRandevuAlimTarihi.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");

            dgwRandevu.AllowUserToAddRows = false;
            dgwRandevu.AllowUserToDeleteRows = false;
            dgwRandevu.ReadOnly = true;
            dgwRandevu.AllowUserToResizeColumns = false;
            dgwRandevu.AllowUserToResizeRows = false;
            dgwRandevu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dgwRandevu.DefaultCellStyle.SelectionForeColor = Color.White;

            List<Il> iller = new List<Il>();

            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM City ORDER BY City.Name", baglanti);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                iller.Add(
                    new Il
                    {
                        Id = okuyucu.GetInt32(0),
                        Ad = okuyucu.GetString(1)
                    }
                    );
            }

            baglanti.Close();

            cbxIl.ValueMember = "Id";
            cbxIl.DisplayMember = "Ad";
            cbxIl.DataSource = iller;
        }

        private void pbxKapat_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmMRS_Kisi_Panel frmMRS_Kisi_Panel = new FrmMRS_Kisi_Panel();

            frmMRS_Kisi_Panel.Visible = true;
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

        private void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            List<Ilce> ilceler = new List<Ilce>();

            Il il = (Il)cbxIl.SelectedItem;

            komut = new SqlCommand("SELECT * FROM District WHERE CityId = @CityId ORDER BY District.Name", baglanti);

            komut.Parameters.AddWithValue("@CityId", il.Id);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                ilceler.Add(
                    new Ilce
                    {
                        Id = okuyucu.GetInt32(0),
                        Ad = okuyucu.GetString(1),
                        Il = il
                    }
                    );
            }

            baglanti.Close();

            cbxIlce.ValueMember = "Id";
            cbxIlce.DisplayMember = "Ad";
            cbxIlce.DataSource = ilceler;
        }

        private void cbxIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            List<Hastane> hastaneler = new List<Hastane>();

            Ilce ilce = (Ilce)cbxIlce.SelectedItem;

            komut = new SqlCommand("SELECT * FROM Hospital WHERE DistrictId = @DistrictId", baglanti);

            komut.Parameters.AddWithValue("@DistrictId", ilce.Id);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                hastaneler.Add(
                    new Hastane
                    {
                        Id = okuyucu.GetInt32(0),
                        Ad = okuyucu.GetString(1),
                        Ilce = ilce,
                        Adres = okuyucu.GetString(3)
                    }
                    );
            }

            baglanti.Close();

            cbxHastane.ValueMember = "Id";
            cbxHastane.DisplayMember = "Ad";
            cbxHastane.DataSource = hastaneler;
        }

        private void cbxHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            List<Klinik> klinikler = new List<Klinik>();

            Hastane hastane = (Hastane)cbxHastane.SelectedItem;

            komut = new SqlCommand("SELECT * FROM Clinic WHERE HospitalId = @HospitalId ORDER BY Clinic.Name", baglanti);

            komut.Parameters.AddWithValue("@HospitalId", hastane.Id);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                klinikler.Add(
                    new Klinik
                    {
                        Id = okuyucu.GetInt32(0),
                        Ad = okuyucu.GetString(1),
                        Hastane = hastane
                    }
                    );
            }

            baglanti.Close();

            cbxKlinik.ValueMember = "Id";
            cbxKlinik.DisplayMember = "Ad";
            cbxKlinik.DataSource = klinikler;
        }

        private void cbxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            List<Doktor> doktorlar = new List<Doktor>();

            Klinik klinik = (Klinik)cbxKlinik.SelectedItem;

            komut = new SqlCommand("SELECT * FROM Doctor WHERE ClinicId = @ClinicId ORDER BY Doctor.Name", baglanti);

            komut.Parameters.AddWithValue("@ClinicId", klinik.Id);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                doktorlar.Add(
                    new Doktor
                    {
                        Id = okuyucu.GetInt32(0),
                        Ad = okuyucu.GetString(1),
                        Soyad = okuyucu.GetString(2),
                        Klinik = klinik
                    }
                    );
            }

            baglanti.Close();

            cbxDoktor.ValueMember = "Id";
            cbxDoktor.DisplayMember = "AdSoyad";
            cbxDoktor.DataSource = doktorlar;
        }

        Doktor doktor;

        private void cbxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            doktor = (Doktor)cbxDoktor.SelectedItem;

            komut = new SqlCommand("SELECT Appointment.Id, Appointment.DateTime [Randevu Zamanı], Doctor.Id, Doctor.Name [Doktor Adı], Doctor.Surname [Doktor Soyadı], Clinic.Id, Clinic.Name [Klinik], Hospital.Id, Hospital.Name [Kurum], Hospital.Address, District.Id, District.Name [İlçe], City.Id, City.Name [İl], Appointment.EnableState, Appointment.GetState FROM Appointment JOIN Doctor ON Appointment.DoctorId = Doctor.Id JOIN Clinic ON Doctor.ClinicId = Clinic.Id JOIN Hospital ON Clinic.HospitalId = Hospital.Id JOIN District ON Hospital.DistrictId = District.Id JOIN City ON District.CityId = City.Id WHERE Appointment.GetState = 0 AND EnableState = 1 AND Doctor.Id = @DoctorId", baglanti);

            komut.Parameters.AddWithValue("@DoctorId", doktor.Id);

            okuyucu = komut.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(okuyucu);

            baglanti.Close();

            dgwRandevu.DataSource = dataTable;

            dgwRandevu.Columns["Id"].Visible = false;
            dgwRandevu.Columns["Id1"].Visible = false;
            dgwRandevu.Columns["Id2"].Visible = false;
            dgwRandevu.Columns["Id3"].Visible = false;
            dgwRandevu.Columns["Id4"].Visible = false;
            dgwRandevu.Columns["Id5"].Visible = false;
            dgwRandevu.Columns["Address"].Visible = false;
            dgwRandevu.Columns["EnableState"].Visible = false;
            dgwRandevu.Columns["GetState"].Visible = false;
        }


        private void dgwRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int randevuId, klinikId, hastaneId;

            Kisi kisi = FrmMRS.kisi;

            dgwRandevu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(78, 184, 206);
            dgwRandevu.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 50, 56);

            int index = dgwRandevu.CurrentCell.RowIndex;

            randevuId = Convert.ToInt32(dgwRandevu.Rows[index].Cells[0].Value);

            klinikId = Convert.ToInt32(dgwRandevu.Rows[index].Cells[5].Value);

            hastaneId = Convert.ToInt32(dgwRandevu.Rows[index].Cells[7].Value);

            baglanti.Open();

            komut = new SqlCommand("SELECT * FROM Appointment_Person JOIN Appointment ON Appointment.Id = Appointment_Person.AppointmentId JOIN Person ON Person.Id = Appointment_Person.PersonId JOIN Doctor ON Appointment.DoctorId = Doctor.Id JOIN Clinic ON Clinic.Id = Doctor.ClinicId JOIN Hospital ON Hospital.Id = Clinic.HospitalId WHERE Appointment.DateTime > GetDate() AND Clinic.Id = @ClinicId AND Hospital.Id = @HospitalId AND Appointment.EnableState = 1 AND Person.Id = @PersonId", baglanti);

            komut.Parameters.AddWithValue("@ClinicId", klinikId);
            komut.Parameters.AddWithValue("@HospitalId", hastaneId);
            komut.Parameters.AddWithValue("@PersonId", kisi.Id);

            okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                MessageBox.Show("Aynı klinikten birden fazla randevu alınamaz", "Hastane Randevu Alma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Randevuyu onaylıyor musunuz?", "Hastane Randevu Alma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    okuyucu.Close();

                    komut = new SqlCommand("INSERT INTO Appointment_Person (AppointmentId, PersonId, GetDate) VALUES (@AppointmentId, @PersonId, @GetDate)", baglanti);

                    komut.Parameters.AddWithValue("@AppointmentId", randevuId);
                    komut.Parameters.AddWithValue("@PersonId", kisi.Id);
                    komut.Parameters.AddWithValue("@GetDate", DateTime.Now.Date);

                    komut.ExecuteNonQuery();

                    komut = new SqlCommand("UPDATE Appointment SET GetState = 1 Where Id = @AppointmentId", baglanti);

                    komut.Parameters.AddWithValue("@AppointmentId", randevuId);

                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Randevu başarıyla onaylandı", "Hastane Randevu Alma", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        komut = new SqlCommand("SELECT Appointment.Id, Appointment.DateTime [Randevu Zamanı], Doctor.Id, Doctor.Name [Doktor Adı], Doctor.Surname [Doktor Soyadı], Clinic.Id, Clinic.Name [Klinik], Hospital.Id, Hospital.Name [Kurum], Hospital.Address, District.Id, District.Name [İlçe], City.Id, City.Name [İl], Appointment.EnableState, Appointment.GetState FROM Appointment JOIN Doctor ON Appointment.DoctorId = Doctor.Id JOIN Clinic ON Doctor.ClinicId = Clinic.Id JOIN Hospital ON Clinic.HospitalId = Hospital.Id JOIN District ON Hospital.DistrictId = District.Id JOIN City ON District.CityId = City.Id WHERE Appointment.GetState = 0 AND EnableState = 1 AND Doctor.Id = @DoctorId", baglanti);

                        komut.Parameters.AddWithValue("@DoctorId", doktor.Id);

                        okuyucu = komut.ExecuteReader();

                        DataTable dataTable = new DataTable();

                        dataTable.Load(okuyucu);

                        dgwRandevu.DataSource = dataTable;
                    }
                }
            }

            baglanti.Close();
        }
    }
}
