using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Libro
    {
        public Libro()
        {
            LibroXautor = new HashSet<LibroXautor>();
            Prestamo = new HashSet<Prestamo>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Debe de llenar el Titulo primero")]
        public string Titulo { get; set; }
        public int? Editorial { get; set; }
        public int? Area { get; set; }

        public virtual Area AreaNavigation { get; set; }
        public virtual Editorial EditorialNavigation { get; set; }
        public virtual ICollection<LibroXautor> LibroXautor { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
