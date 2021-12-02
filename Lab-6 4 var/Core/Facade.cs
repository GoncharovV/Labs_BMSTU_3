using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseContext;
using DatabaseModels;


namespace Core
{
    public class Facade
    {

        private DoctorsManager _doctorsManager;
        private CertificatesManager _certificatesManager;
        private SpecializationsManager _specializationsManager;
        private BuisnessTasks _buisnessTasks;

        public Facade(DoctorsManager doctorsManager, CertificatesManager certificatesManager,
            SpecializationsManager specializationsManager, BuisnessTasks buisnessTasks)
        {
            _doctorsManager = doctorsManager;
            _certificatesManager = certificatesManager;
            _specializationsManager = specializationsManager;
            _buisnessTasks = buisnessTasks;
        }

        public void CreateDoctor(int id, string name, int specializationId)
        {
            _doctorsManager.CreateDoctor(id, name, specializationId);
        }

        public void CreateCertificate(int id, int doctorId, string description)
        {
            _certificatesManager.CreateCertificates(id, doctorId, description);
        }

        public void CreateSpecialization(int id, string name)
        {
            _specializationsManager.CreateSpecialization(id, name);
        }

        public void DeleteDoctor(int id)
        {
            _doctorsManager.DeleteDoctor(id);
        }

        public void DeleteCertificate(int id)
        {
            _certificatesManager.DeleteCertificates(id);
        }

        public void DeleteSpecialization(int id)
        {
            _specializationsManager.DeleteSpecialization(id);
        }

        public void ChangeDoctor(int id, string name, int specializationId)
        {
            _doctorsManager.ChangeDoctor(id, name, specializationId);
        }

        public void ChangeCertificate(int id, int doctorId, string description)
        {
            _certificatesManager.ChangeCertificates(id, description, doctorId);
        }

        public void ChangeSpecialization(int id, string name)
        {
            _specializationsManager.ChangeSpecialization(id, name);
        }

        public DbSet<Doctor> GetDoctors()
        {
            return _doctorsManager.GetDoctors();
        }

        public DbSet<Certificate> GetCertificates()
        {
            return _certificatesManager.GetCertificates();
        }

        public DbSet<Specialization> GetSpecialization()
        {
            return _specializationsManager.GetSpecializations();
        }

        public int CountDoctorsWithSpecialization(int id)
        {
            return _buisnessTasks.CountDoctorsWithSpecialization(id);
        }

        public string GetNameOfSpecialization(int id)
        {
            return _buisnessTasks.GetNameOfSpecialization(id);
        }

        public DateTime GetLastCertificate(int id)
        {
            return _buisnessTasks.GetLastCertificate(id);
        }
    }
}
