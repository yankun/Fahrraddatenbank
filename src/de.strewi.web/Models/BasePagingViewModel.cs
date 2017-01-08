using de.strewi.database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
    public class BasePagingViewModel<T> where T : new()
    {
        private int itemsPerPage = 50;

        public int Page { get; set; }

        public int PagesTotal { get; set; }

        public int ItemsPerPage
        {
            get
            {
                return itemsPerPage;
            }
            set
            {
                //Lets think of beeing 100 is a healthy value
                if (value <= 100)
                {
                    itemsPerPage = value;
                } else
                {
                    itemsPerPage = 100;
                }
            }

        }

        public IEnumerable<T> PageItems { get; set; }
    }
}
