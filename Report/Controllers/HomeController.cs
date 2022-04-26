using Report.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Report.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Reporte(string type)
        {


            var report = General.RenderReports(
                Server.MapPath("~/Reportes/ListaEstudiantes.rdlc"),
                new List<string> { "Cotizacion" },
                new List<object> { this.generarCotizacion() },
                type
                );
            return File(report.Item1, report.Item2);
        }

        private Cotizacion generarCotizacion()
        {
            List<Parametro> parametros2 = new List<Parametro> {
                new Parametro
                {
                                                    FisicoQuimico = "Grasa",
                                TecnicaAnalisis = "Gravimetría (Secado en estufa hasta peso constante)",
                                Cantidad = 2,
                                PrecioUnitario = 10000,
                                PrecioTotal = 20000
                }
                ,
                new Parametro
                {
                    FisicoQuimico = "Nitrógeno y proteína",
                    TecnicaAnalisis = "Termo balanza",
                    Cantidad = 2,
                    PrecioUnitario = 25148,
                    PrecioTotal = 50296
                },
                new Parametro
                {
                    FisicoQuimico = "Humedad y materia seca",
                    TecnicaAnalisis = "Gravimetría (Secado en estufa hasta peso constante)",
                    Cantidad = 2,
                    PrecioUnitario = 26676,
                    PrecioTotal = 53352
                },
                new Parametro
                {
                    FisicoQuimico = "Humedad y materia seca",
                    TecnicaAnalisis = "Termo balanza",
                    Cantidad = 2,
                    PrecioUnitario = 14040,
                    PrecioTotal = 28080
                }
            };

            Producto producto1 = new Producto
            {
                Nombre = "Caramelo",
                Componentes = new List<Componente>
                {
                    new Componente
                    {
                        TipoComponente = "1",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Humedad y materia seca",
                                TecnicaAnalisis = "Gravimetría (Secado en estufa hasta peso constante)",
                                Cantidad = 1,
                                PrecioUnitario = 26676,
                                PrecioTotal = 26676
                            }
                    },
                    new Componente
                    {
                        TipoComponente = "2",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Nitrógeno y proteína",
                                TecnicaAnalisis = "Termo balanza",
                                Cantidad = 1,
                                PrecioUnitario = 25148,
                                PrecioTotal = 25148
                            }
                    },
                     new Componente
                    {
                        TipoComponente = "3",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Nitrógeno y proteína",
                                TecnicaAnalisis = "Termo balanza",
                                Cantidad = 1,
                                PrecioUnitario = 25148,
                                PrecioTotal = 25148
                            }
                    }
                }

            };

            Producto producto2 = new Producto
            {
                Nombre = "Caramelo",
                Componentes = new List<Componente>
                {
                    new Componente
                    {
                        TipoComponente = "1",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Grasa",
                                TecnicaAnalisis = "Gravimetría (Secado en estufa hasta peso constante)",
                                Cantidad = 2,
                                PrecioUnitario = 10000,
                                PrecioTotal = 20000
                            }
                    },
                    new Componente
                    {
                        TipoComponente = "2",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Nitrógeno y proteína",
                                TecnicaAnalisis = "Termo balanza",
                                Cantidad = 2,
                                PrecioUnitario = 25148,
                                PrecioTotal = 50296
                            }
                    },
                     new Componente
                    {
                        TipoComponente = "3",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Humedad y materia seca",
                                TecnicaAnalisis = "Gravimetría (Secado en estufa hasta peso constante)",
                                Cantidad = 2,
                                PrecioUnitario = 26676,
                                PrecioTotal = 53352
                            }
                    },
                    new Componente
                    {
                        TipoComponente = "4",
                        Parametro =
                            new Parametro
                            {
                                FisicoQuimico = "Humedad y materia seca",
                                TecnicaAnalisis = "Termo balanza",
                                Cantidad = 2,
                                PrecioUnitario = 14040,
                                PrecioTotal = 28080
                            }
                    }
                }

            };

            Subcotizacion subcotizacion1 = new Subcotizacion
            {
                Productos = new List<Producto>
                {
                    producto1,
                    producto2
                }
            };

            Cotizacion cotizacion = new Cotizacion
            {
                Fecha = new DateTime(),
                RazonSocial = "Super de Alimentos",
                Referencia = "Para super",
                Estado = "Creada",
                Subcotizaciones = new List<Subcotizacion>
                {
                    subcotizacion1
                }

            };

            return cotizacion;
        }
    }
}