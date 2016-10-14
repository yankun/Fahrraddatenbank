using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using de.strewi.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace de.strewi.web.Controllers
{
	public class UploadController : Controller
	{
		[HttpGet]
		public IActionResult SelectType()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SelectType(string type)
		{
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