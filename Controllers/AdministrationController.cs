using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Medica.Data;
using Medica.Models;
using Medica.ViewModels;
using Microsoft.AspNetCore.Authorization.Infrastructure;
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

        [HttpGet]
        public IActionResult CreateRole(){
            return View();
        }

       [HttpPost]
         public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole{
                        Name=model.RoleName
                    };
                IdentityResult result=await roleManager.CreateAsync(identityRole);
                
                if(result.Succeeded)
                    {
                    return Redirect("~/Home/Index");

                    }
               else{
                   return NotFound();
                    }
            }
            return View(model);

        }

        

    }

}