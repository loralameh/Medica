using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Medica.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Microsoft.AspNetCore.Identity;

namespace Medica.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName{ get; set; }
     
    }
}