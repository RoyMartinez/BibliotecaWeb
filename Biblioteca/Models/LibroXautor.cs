using System;
using System.Collections.Generic;

namespace Biblioteca.Models
{
    public partial class LibroXautor
    {
        public int Autor { get; set; }
        public int Libro { get; set; }

        public virtual Autor AutorNavigation { get; set; }
        public virtual Libro LibroNavigation { get; set; }
    }
}
