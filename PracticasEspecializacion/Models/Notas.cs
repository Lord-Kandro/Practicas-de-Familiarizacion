using PracticasEspecializacion.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticasEspecializacion.Models
{
    public class Notas
    {
        [Key]
        public int IdNotas { get; set; }

        [Display(Name ="Título")]
        public string titulo { get; set; }

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }

        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
