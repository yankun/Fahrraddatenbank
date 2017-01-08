using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    //Buch, Zeitschrift, Großhandelskatalog, Firmenporpekt, Jubiläumsschrift 


    public enum DocumentType : int
    {
        AnniverseryFlyer,
        Book,
        Commercial,
        Flyer,
        Magazine,
        ManufacturerCatalog,
        RetailCatalog
    }
}
