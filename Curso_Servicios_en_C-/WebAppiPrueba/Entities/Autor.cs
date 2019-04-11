using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppiPrueba.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        //[Required] hace la validación para que este parametro sea requerido y no hacer nuestras propias validaciones
        [Required]
        [StringLength(10, ErrorMessage = "El campo nombre debe tener {1} caracteres o menos ")]
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }
        [Range(18,50)]
        public int Edad { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }
        [Url]
        public string Url { get; set; }

    }
}
