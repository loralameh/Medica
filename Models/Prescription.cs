using System;

namespace Medica.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public string DrFirstName { get; set; }
        public string DrLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string DiseaseDiscription { get; set; }
        public string MedicinName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PillsPerDay { get; set; }
        public string Instructions { get; set; }



    }
}