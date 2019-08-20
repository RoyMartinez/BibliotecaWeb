using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Prestamo = new HashSet<Prestamo>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el Carnet primero")]
        public string Carnet { get; set; }
        [DisplayName("Estudiante")]
        [Required(ErrorMessage = "Ingrese la Estudiante primero")]
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public string Direccion { get; set; }
        public int? Carrera { get; set; }

        public virtual Carrera CarreraNavigation { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
