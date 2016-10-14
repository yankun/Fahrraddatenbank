using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models.SearchViewModels
{
	public class ResultsViewModel
	{
		public string SearchTerm { get; set; }
		public IEnumerable<Result> Results { get; set; }
	}
}
