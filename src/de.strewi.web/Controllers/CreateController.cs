using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using de.strewi.web.Models;
using Microsoft.AspNetCore.Mvc;
using de.strewi.database.Models;

namespace de.strewi.web.Controllers
{
	public class CreateController : Controller
	{
		[HttpGet]
		public IActionResult SelectType(string type)
		{
            if(string.IsNullOrWhiteSpace(type))
            {
                return View();
            }

			switch(type) {
				case nameof(HeadBadge):
					return RedirectToAction("Create", nameof(HeadBadge), new { type = type });
				case nameof(Manufacturer):
					return RedirectToAction("Create", nameof(Manufacturer), new { type = type });
				default:
					return RedirectToAction("Unknown");
			}
			
		}

		public IActionResult Unknown()
		{
			return View();
		}

		public IActionResult Create(string type)
		{
			return View();
		}
	}
}