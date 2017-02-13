using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using de.strewi.web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using de.strewi.database.Models;
using de.strewi.database;

namespace de.strewi.web.Areas.Admin.Controllers
{
    [Authorize(Roles = Role.ROLE_ADMIN + "," + Role.ROLE_SUPERADMIN)]
    [Area("Admin")]
    public class AccountController : Controller
    {
        private ApplicationDbContext dbContext;

        public AccountController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index(AccountPagingViewModel model)
        {
            if (model == null)
            {
                model = new AccountPagingViewModel();
            }

            model.PageItems = dbContext.Users;

            return View(model);
        }

        public IActionResult Details(Guid id)
        {
            var user = dbContext.Users.First(u => u.Id == id);

            return View(user);
        }
    }
}