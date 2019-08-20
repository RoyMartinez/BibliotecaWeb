using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        public int Id { get; set; }
        [DisplayName("Carrera")]
        [Required(ErrorMessage = "Ingrese la Carrera primero")]
        public string Nombre { get; set; }

        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}
