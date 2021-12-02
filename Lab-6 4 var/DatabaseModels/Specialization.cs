using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Specialization
    {
        public Specialization(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
