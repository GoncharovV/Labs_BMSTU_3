using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class SpecializationsManager
    {
        private DoctorsContext _context;

        public SpecializationsManager(DoctorsContext context)
        {
            _context = context;
        }

        public void CreateSpecialization(int id, string name)
        {
            Specialization specialization = new Specialization(id, name);
            _context.Add(specialization);
            _context.SaveChanges();
        }

        public void DeleteSpecialization(int id)
        {
            Specialization specialization = _context.Specializations.Find(id);
            _context.Remove(specialization);
            _context.SaveChanges();
        }

        public void ChangeSpecialization(int id, string name)
        {
            Specialization specialization = _context.Specializations.Find(id);
            specialization.Name = name;
            _context.SaveChanges();
        }

        public DbSet<Specialization> GetSpecializations()
        {
            return _context.Specializations;
        }

    }
}
