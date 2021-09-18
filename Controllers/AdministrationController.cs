using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medica.Data;
using Medica.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Medica.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;

        }

    }

}