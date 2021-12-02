using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Doctor
    { 
        public Doctor(int id, string name, int specializationId)
        {
            Id = id;
            Name = name;
            SpecializationId = specializationId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}
