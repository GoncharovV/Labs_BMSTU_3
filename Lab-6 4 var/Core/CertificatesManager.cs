using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;


namespace Core
{
    public class CertificatesManager
    {
        private DoctorsContext _context;
        public CertificatesManager(DoctorsContext context)
        {
            _context = context;
        }

        public void CreateCertificates(int id, int doctorId, string description)
        {
            Certificate certificate = new Certificate(id, doctorId, description);
            _context.Add(certificate);
            _context.SaveChanges();
        }

        public void DeleteCertificates(int id)
        {
            Certificate certificate = _context.Certificates.Find(id);
            _context.Remove(certificate);
            _context.SaveChanges();
        }

        public void ChangeCertificates(int id, string description, int doctorId)
        {
            Certificate certificate = _context.Certificates.Find(id);
            certificate.Decription = description;
            certificate.DoctorId = doctorId;
            _context.SaveChanges();
        }

        public DbSet<Certificate> GetCertificates()
        {
            return _context.Certificates;
        }
    }
}
