using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Crear un paciente
                var patient = new Patient
                {
                    Name = "John Doe",
                    Id = "123456",
                    PhoneNumber = "555-1234",
                    Age = 30
                };

                // Crear un doctor
                var doctor = new Doctor
                {
                    Name = "Dr. Smith",
                    Speciality = "Cardiology"
                };

                // Programar una consulta
                var consultationService = new ConsultationService();
                var date = DateTime.Now.AddDays(2);
                var location = "Medical Center Room 101";
                var consultation = consultationService.ScheduleConsultation(patient, doctor, date, location);

                // Mostrar detalles de la consulta
                Console.WriteLine($"Consultation ID: {consultation.Id}");
                Console.WriteLine($"Patient: {consultation.Patient.Name}");
                Console.WriteLine($"Doctor: {consultation.Doctor.Name}");
                Console.WriteLine($"Date: {consultation.Date}");
                Console.WriteLine($"Location: {consultation.Location}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
