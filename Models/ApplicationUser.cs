using System;
using System.Security.Policy;
using Microsoft.AspNetCore.Identity;

namespace Medica.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int DoctorId { get; set; }
        public bool AreUDoctor { get; set; }
        public bool AreUPatient{ get; set; }
        public string DoctorSpeciality { get; set; }
    }
}