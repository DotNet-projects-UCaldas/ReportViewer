using System;

namespace Report.Models
{
    public class Estudiantes
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Grado { get; set; }
        public string Matricula { get; set; }
        public string Alumno { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Profesor { get; set; }
    }
}