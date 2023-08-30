using System;

namespace Library
{
    public class ConsultationService
    {
        public Consultation ScheduleConsultation(Patient patient, Doctor doctor, DateTime date, string location)
        {
            DataValidation.ValidatePatient(patient);
            DataValidation.ValidateDoctor(doctor);

            var consultation = new Consultation(patient, doctor)
            {
                Date = date,
                Location = location
            };

            DataValidation.ValidateConsultation(consultation);

            // Aquí podrías guardar la consulta en tu sistema de almacenamiento

            return consultation;
        }
    }
}
