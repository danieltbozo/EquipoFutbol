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
        [Key]
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public int Edad { get; set; }
        
        public virtual Equipo Equipo { get; set; }
        [ForeignKey("IdEquipo")]
        public int IdEquipo { get; set; }

        public virtual List<Equipo> Equipos { get; set; }
    }
}
