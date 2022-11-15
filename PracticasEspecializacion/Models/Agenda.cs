using PracticasEspecializacion.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PracticasEspecializacion.Models
{
    public class Agenda
    {
        [Key]
        public int IdAgenda { get; set; }

        [Display(Name = "Nombre del paciente")]
        public string paciente { get; set; }

        [Display(Name = "Fecha de cita")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Observación")]
        public string observacion { get; set; }

        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
