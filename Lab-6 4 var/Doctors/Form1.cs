using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Microsoft.EntityFrameworkCore;
using DatabaseContext;

namespace Doctors
{
    public partial class Form1 : Form
    {
        private Facade facade;
        public Form1()
        {
            InitializeComponent();

            string connectionString = "User ID=postgres;Password=root;Server=localhost;Port=5432;Database=doctors;";

            var optionsBuilder = new DbContextOptionsBuilder<DoctorsContext>();

            optionsBuilder.UseNpgsql(connectionString);

            DoctorsContext context = new DoctorsContext(optionsBuilder.Options);

            DoctorsManager doctorsManager = new DoctorsManager(context);
            CertificatesManager certificatesManager = new CertificatesManager(context);
            SpecializationsManager specializationsManager = new SpecializationsManager(context);
            BuisnessTasks buisnessTasks = new BuisnessTasks(context);

            facade = new Facade(doctorsManager, certificatesManager, specializationsManager, buisnessTasks);



            certificatesGrid.Columns.Add("Id", "ID");
            certificatesGrid.Columns.Add("DoctorId", "Доктор");
            certificatesGrid.Columns.Add("Desc", "Описание");
            certificatesGrid.Columns.Add("Date", "Дата выдачи");


            doctorsGrid.Columns.Add("Id", "ID");
            doctorsGrid.Columns.Add("Name", "Имя");
            doctorsGrid.Columns.Add("SpesId", "Специализация");

            specializationGrid.Columns.Add("Id", "ID");
            specializationGrid.Columns.Add("Name", "Название");
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Произошла ошибка");
        }

        private void loadDoctors_Click(object sender, EventArgs e)
        {
            doctorsGrid.Rows.Clear();

            var doctors = facade.GetDoctors();

            foreach(var doctor in doctors)
            {
                doctorsGrid.Rows.Add(doctor.Id, doctor.Name, doctor.SpecializationId);
            }
        }

        private void loadCertificates_Click(object sender, EventArgs e)
        {
            certificatesGrid.Rows.Clear();

            var certificates = facade.GetCertificates();

            foreach (var certificate in certificates)
            {
                certificatesGrid.Rows.Add(certificate.Id, certificate.DoctorId, certificate.Decription, certificate.Date.ToString());
            }
        }

        private void specializationLoad_Click(object sender, EventArgs e)
        {
            specializationGrid.Rows.Clear();

            var specializations = facade.GetSpecialization();

            foreach (var specialization in specializations)
            {
                specializationGrid.Rows.Add(specialization.Id, specialization.Name);
            }
        }

        private void createDoctorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(doctorIdTb.Text);
                string name = doctorNameTb.Text;
                int specializationsId = int.Parse(doctorSpecId.Text);

                facade.CreateDoctor(id, name, specializationsId);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void changeDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(doctorIdTb.Text);
                string name = doctorNameTb.Text;
                int specializationsId = int.Parse(doctorSpecId.Text);

                facade.ChangeDoctor(id, name, specializationsId);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void deleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(doctorIdTb.Text);

                facade.DeleteDoctor(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void createCer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cerIdTb.Text);
                string description = cerDescTb.Text;
                int doctorId = int.Parse(cerDoctorTb.Text);

                facade.CreateCertificate(id, doctorId, description);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void changeCer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cerIdTb.Text);
                string description = cerDescTb.Text;
                int doctorId = int.Parse(cerDoctorTb.Text);

                facade.ChangeCertificate(id, doctorId, description);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void deleteCer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cerIdTb.Text);

                facade.DeleteCertificate(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void createSpes_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(specIdTb.Text);
                string name = specNameTb.Text;

                facade.CreateSpecialization(id, name);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void changeSpec_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(specIdTb.Text);
                string name = specNameTb.Text;

                facade.ChangeSpecialization(id, name);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void deleteSpec_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(specIdTb.Text);

                facade.DeleteSpecialization(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void countDoctors_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(countDoctorsTb.Text);

                doctorsCountLabel.Text = facade.CountDoctorsWithSpecialization(id).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void findSpec_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSpecTb.Text);

                findSpecLabel.Text = facade.GetNameOfSpecialization(id);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void cerDate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cerDateTb.Text);

                cerDateLabel.Text = facade.GetLastCertificate(id).ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
