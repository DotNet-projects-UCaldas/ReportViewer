using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Subcotizacion
    {
        public String Id { get; set; }
        public List<Producto> Productos { get; set; }
        public int ValorTotal { get; set; }
        
        public Subcotizacion()
        {
            this.Id = new Guid().ToString();
        }
    }
}