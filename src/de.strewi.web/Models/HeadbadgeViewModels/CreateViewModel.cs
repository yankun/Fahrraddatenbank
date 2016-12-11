using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using de.strewi.database.Models;

namespace de.strewi.web.Models.HeadbadgeViewModels
{
	public class CreateViewModel : HeadBadge
	{
		[Display(Name = nameof(UploadImage), ResourceType = typeof(de.strewi.database.Resources.PropertyNames))]
		[DataType(DataType.Upload)]
		[Required(ErrorMessage = "Für ein Steuerkopfschild muss ein Bild hochgeladen werden.")]
		public IFormFile UploadImage { get; set; }
	}
}
