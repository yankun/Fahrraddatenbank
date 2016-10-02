using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace de.strewi.web.Models.BearingShellViewModels
{
	public class CreateBearingShellViewModel : BearingShell
	{
		[DataType(DataType.Upload)]
		public IFormFile ImageUpload { get; set; }
	}
}
