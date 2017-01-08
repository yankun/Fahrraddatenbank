using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using de.strewi.web.Areas.Admin.Models;

namespace de.strewi.web.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(AccountPagingViewModel model)
        {
            return View();
        }
    }
}