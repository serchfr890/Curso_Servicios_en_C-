using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppiPrueba.Entities
{
    public class Libro
    {
        public int Id { set; get; }
        [Required]
        public string Titulo { set; get; }
        [Required]
        public int AutorId { set; get; }
        public Autor autor { set; get; }
    }
}
