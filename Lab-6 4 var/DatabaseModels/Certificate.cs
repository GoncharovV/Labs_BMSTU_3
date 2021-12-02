using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Certificate
    {
        public Certificate(int id, int doctorId, string decription)
        {
            Id = id;
            DoctorId = doctorId;
            Decription = decription;
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public string Decription { get; set; }
        public DateTime Date { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
