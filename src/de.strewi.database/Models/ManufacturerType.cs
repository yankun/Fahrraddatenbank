using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public enum ManufacturerType : int
    {
        /// <summary>
        /// AddOns like Tires, Saddles, Lights, Like Continentasl, Scharlach
        /// </summary>
        AddOns = 0,
        /// <summary>
        /// Reseller, offering generic hardware from others and also bicycles under a own label like Bernd Wedler
        /// </summary>
        Reseller,
        /// <summary>
        /// Original producer of bicycle/parts like Dürkopp, Brennabor
        /// </summary>
        Producer
    }
}
