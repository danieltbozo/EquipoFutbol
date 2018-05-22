using EquipoFutbol1.Models;
using System;
using System.Linq;

namespace EquipoFutbol1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FutbolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Equipos.Any())
            {
                return;   // DB has been seeded
            }

            var equipos = new Equipo[]
            {
            //new Equipo{IdEquipo=1, NombreEquipo="Argentina"},
            //new Equipo{IdEquipo=2,NombreEquipo="Bolivia"},
            //new Equipo{IdEquipo=3,NombreEquipo="Brasil"},
            //new Equipo{IdEquipo=4,NombreEquipo="Alemania"},

             new Equipo{NombreEquipo="Argentina"},
             new Equipo{NombreEquipo="Bolivia"},
             new Equipo{NombreEquipo="Brasil"},
             new Equipo{NombreEquipo="Alemania"},
            };
            foreach (var e in equipos)
            {
                context.Equipos.Add(e);
            }
            context.SaveChanges();

            var jugadores = new Jugador[]
            {
            new Jugador{IdJugador=1, NombreJugador="Jugador1Eq1", Edad=20, IdEquipo=1},
            new Jugador{IdJugador=2, NombreJugador="Jugador2Eq1", Edad=21, IdEquipo=1},
            new Jugador{IdJugador=3, NombreJugador="Jugador3Eq1", Edad=20, IdEquipo=1},
            new Jugador{IdJugador=4, NombreJugador="Jugador1Eq2", Edad=20, IdEquipo=2},
            new Jugador{IdJugador=5, NombreJugador="Jugador2Eq2", Edad=21, IdEquipo=2},
            new Jugador{IdJugador=6, NombreJugador="Jugador3Eq2", Edad=20, IdEquipo=2},
            };
            foreach (var j in jugadores)
            {
                context.Jugadores.Add(j);
            }
            context.SaveChanges();
        }
    }
}