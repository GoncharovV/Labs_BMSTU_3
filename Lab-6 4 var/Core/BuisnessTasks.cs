using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using System.Linq;


namespace Core
{
    public class BuisnessTasks
    {
        private DoctorsContext _context;
        public BuisnessTasks(DoctorsContext context)
        {
            _context = context;
        }

        public int CountDoctorsWithSpecialization(int id)
        {
            return _context.Doctors.Count(d => d.SpecializationId == id);
        }

        public string GetNameOfSpecialization(int id)
        {
            int doctorId = _context.Certificates.Find(id).DoctorId;
            return _context.Doctors.Find(doctorId).Specialization.Name;
        }

        public DateTime GetLastCertificate(int id)
        {
            ICollection<Certificate> certificates = _context.Doctors.Find(id).Certificates;
            DateTime dateTime = certificates.Max(d => d.Date);
            return dateTime;
        }
    }
}
