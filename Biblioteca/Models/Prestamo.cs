using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Prestamo
    {
        public int Estudiante { get; set; }
        public int Libro { get; set; }
        [DisplayName("Fecha de Prestamo")]
        [DataType(DataType.DateTime)]
        public DateTime? FechaPrestamo { get; set; }
        [DisplayName("Fecha de Devolucion")]
        [DataType(DataType.DateTime)]
        public DateTime? FechaDevolucion { get; set; }
        public string Devuelto { get; set; }

        public virtual Estudiante EstudianteNavigation { get; set; }
        public virtual Libro LibroNavigation { get; set; }
    }
}
