using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class ModerationItem : BaseModel
    {
        public string Controller { get; set; }

        public string Action { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }
    }
}
