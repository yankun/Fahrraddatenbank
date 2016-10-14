using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace de.strewi.web.Controllers
{
    public class HeadBadgeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}