using System;

namespace Library
{
    public class Consultation
    {
        public Guid Id { get; }
        public Patient Patient { get; }
        public Doctor Doctor { get; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public Consultation(Patient patient, Doctor doctor)
        {
            Id = Guid.NewGuid();
            Patient = patient;
            Doctor = doctor;
        }
    }
}
