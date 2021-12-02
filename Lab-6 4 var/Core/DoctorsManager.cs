using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DoctorsManager
    {
        private DoctorsContext _context;
        public DoctorsManager(DoctorsContext context)
        {
            _context = context;
        }

        public void CreateDoctor(int id, string name, int specializationId)
        {
            Doctor doctor = new Doctor(id, name, specializationId);
            _context.Add(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            Doctor doctor = _context.Doctors.Find(id);
            _context.Remove(doctor);
            _context.SaveChanges();
        }

        public void ChangeDoctor(int id, string name, int specializationId)
        {
            Doctor doctor = _context.Doctors.Find(id);
            doctor.Name = name;
            doctor.SpecializationId = specializationId;
            _context.SaveChanges();
        }

        public DbSet<Doctor> GetDoctors()
        {
            return _context.Doctors;
        }
    }
}
