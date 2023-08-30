using System;

namespace Library
{
    public static class DataValidation
    {
        public static void ValidatePatient(Patient patient)
        {
            if (string.IsNullOrEmpty(patient.Name))
            {
                throw new ArgumentException("Patient name is required");
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                throw new ArgumentException("Patient ID is required");
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                throw new ArgumentException("Patient phone number is required");
            }

            if (patient.Age <= 0)
            {
                throw new ArgumentException("Patient age is invalid");
            }
        }

        public static void ValidateDoctor(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.Name))
            {
                throw new ArgumentException("Doctor name is required");
            }

            if (string.IsNullOrEmpty(doctor.Speciality))
            {
                throw new ArgumentException("Doctor speciality is required");
            }
        }

        public static void ValidateConsultation(Consultation consultation)
        {
            if (consultation.Patient == null)
            {
                throw new ArgumentNullException(nameof(consultation.Patient), "Patient is required");
            }

            if (consultation.Doctor == null)
            {
                throw new ArgumentNullException(nameof(consultation.Doctor), "Doctor is required");
            }

            if (consultation.Date < DateTime.Now)
            {
                throw new ArgumentException("Consultation date must be in the future");
            }

            if (string.IsNullOrEmpty(consultation.Location))
            {
                throw new ArgumentException("Consultation location is required");
            }
        }
    }
}
