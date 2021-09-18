using System;
using System.Security.Policy;
using Microsoft.AspNetCore.Identity;

namespace Medica.Models
{
    public class DoctorUser: ApplicationUser
    {
  
        public int DoctorId { get; set; }
        public string DoctorSpeciality { get; set; }
    }
}