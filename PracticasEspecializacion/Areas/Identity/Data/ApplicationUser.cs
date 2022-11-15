using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PracticasEspecializacion.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string nombre { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string apellido { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(12)")]
        public string celular { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(16)")]
        public string cedula { get; set; }

        
    }
}
