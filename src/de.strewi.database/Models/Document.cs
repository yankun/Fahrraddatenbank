using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class Document : BaseTimePeriodModel
    {
        [MaxLength(255, ErrorMessageResourceName = nameof(Resources.ErrorMessages.GenericLengthError), ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string OCRContent { get; set; }
    }
}
