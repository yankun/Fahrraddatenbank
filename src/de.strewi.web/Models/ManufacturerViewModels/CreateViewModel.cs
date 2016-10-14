using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace de.strewi.web.Models.ManufacturerViewModels
{
	public class CreateViewModel : Manufacturer
	{
		[Display(Name = nameof(UploadImage), ResourceType = typeof(Resources.PropertyNames))]
		[DataType(DataType.Upload)]
		[Required(ErrorMessage = "Für ein Steuerkopfschild muss ein Bild hochgeladen werden.")]
		public IFormFile UploadImage { get; set; }
	}
}
