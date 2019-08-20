using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Area
    {
        public Area()
        {
            Libro = new HashSet<Libro>();
        }

        public int Id { get; set; }

        [DisplayName("Area")]
        [Required(ErrorMessage = "Ingrese el area primero")]
        public string Nombre { get; set; }
        [DisplayName("Fecha de Registro")]
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
