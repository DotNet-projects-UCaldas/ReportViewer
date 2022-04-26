using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Producto
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public List<Componente> Componentes { get; set; }

        public Producto()
        {
            this.Id = new Guid().ToString();
        }
    }
}