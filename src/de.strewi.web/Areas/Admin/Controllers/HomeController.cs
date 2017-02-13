using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using de.strewi.database.Models;

namespace de.strewi.web.Areas.Admin.Controllers
{
    [Authorize(Roles = Role.ROLE_ADMIN + "," + Role.ROLE_SUPERADMIN)]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}