using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public partial class Autor
    {
        public Autor()
        {
            LibroXautor = new HashSet<LibroXautor>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Debe de llenar el Nombre primero")]
        [DisplayName("Autor")]
        public string Nombre { get; set; }
        public int? Nacionalidad { get; set; }

        public virtual Nacionalidad NacionalidadNavigation { get; set; }
        public virtual ICollection<LibroXautor> LibroXautor { get; set; }
    }
}
