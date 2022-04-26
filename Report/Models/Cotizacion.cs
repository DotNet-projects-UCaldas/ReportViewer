using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Cotizacion
    {
        public DateTime Fecha { get; set; }
        public String RazonSocial { get; set; }
        public String Referencia { get; set; }
        public String Estado { get; set; }
        public List<Subcotizacion> Subcotizaciones { get; set; }
    }
}