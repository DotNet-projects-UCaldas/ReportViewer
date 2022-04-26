using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class Parametro
    {
        public String Id { get; set; }
        public String FisicoQuimico { get; set; }
        public String TecnicaAnalisis { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        private int precioTotal;

        public int PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = this.Cantidad * this.PrecioUnitario; }
        }

        public Parametro()
        {
            this.Id = new Guid().ToString();
        }
    }
}