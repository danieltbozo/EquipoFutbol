using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol1.Models
{
    public class Jugador
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public int Edad { get; set; }

        [ForeignKey("IdEquipo")]
        public virtual Equipo Equipo { get; set; }
        public int IdEquipo { get; set; }
    }
}
