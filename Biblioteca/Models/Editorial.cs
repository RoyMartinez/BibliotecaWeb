using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Editorial
    {
        public Editorial()
        {
            Libro = new HashSet<Libro>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage="Debe de llenar el nombre primero")]
        [DisplayName("Editorial")]
        public string Nombre { get; set; }
        [DisplayName("Fecha de Registro")]
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
