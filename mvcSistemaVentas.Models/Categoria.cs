using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSistemaVentas.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre para la categoría")]
        [Display(Name = "Ingrese el nombre de la categoria")]
        public string Nombre { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.DateTime)]
        public DateTime Fecharegistro { get; set; }
    }
}
