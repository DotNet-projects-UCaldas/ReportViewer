using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Componente
    {
        public String Id { get; set; }
        public String TipoComponente { get; set; }
        public Parametro Parametro { get; set; }

        public Componente()
        {
            this.Id = new Guid().ToString();
        }
    }
}