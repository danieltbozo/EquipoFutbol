using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol1.Models
{
    public class Equipo
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }      
    }
}
