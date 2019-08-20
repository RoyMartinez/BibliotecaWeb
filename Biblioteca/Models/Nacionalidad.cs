using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Nacionalidad
    {
        public Nacionalidad()
        {
            Autor = new HashSet<Autor>();
        }

        public int Id { get; set; }
        [DisplayName("Nacionalidad")]
        [Required(ErrorMessage = "Debe de llenar la Nacionalidad primero")]
        public string Nacionalidad1 { get; set; }

        public virtual ICollection<Autor> Autor { get; set; }
    }
}
