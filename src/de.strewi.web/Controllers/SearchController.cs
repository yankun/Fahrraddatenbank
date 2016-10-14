using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using de.strewi.web.Models.SearchViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace de.strewi.web.Controllers
{
	public class SearchController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View(new IndexViewModel());
		}

		[HttpPost]
		public IActionResult Index(IndexViewModel viewModel)
		{
			return RedirectToAction("Results", new { queryTerm = viewModel.QueryTerm });
		}

		public IActionResult Highlighted()
		{
			return View(new ResultsViewModel {
				SearchTerm = "Welt-Rad"
			});
		}

		public IActionResult Results(string queryTerm)
		{
			return View(new ResultsViewModel {
				SearchTerm = "Welt-Rad"
			});
		}
	}
}
