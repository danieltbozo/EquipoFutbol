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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public virtual List<Jugador> Jugadores { get; set; }
    }
}
