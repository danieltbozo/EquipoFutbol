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
                new Jugador{NombreJugador="Lionel Messi", Edad=24, IdEquipo=1},
                new Jugador{NombreJugador="Hernán Crespo", Edad=21, IdEquipo=1},
                new Jugador{NombreJugador="Gabriel Omar Batistuta", Edad=20, IdEquipo=1},
                new Jugador{ NombreJugador="Gonzalo Higuain", Edad=20, IdEquipo=1},
                new Jugador{NombreJugador="Sergio Aguero", Edad=21, IdEquipo=1},
                new Jugador{ NombreJugador="Ariel Ortega", Edad=20, IdEquipo=1},
                new Jugador{ NombreJugador="Claudio Javier López", Edad=20, IdEquipo=1},
                new Jugador{ NombreJugador="Juan Román Riquelme", Edad=24, IdEquipo=1},
                new Jugador{NombreJugador="Oreste Corbatta", Edad=22, IdEquipo=1},
                new Jugador{NombreJugador="Juan Sebastián Vero", Edad=23, IdEquipo=1},

                new Jugador{NombreJugador="Joaquín Botero", Edad=24, IdEquipo=2},
                new Jugador{NombreJugador="Victor Agustín Ugarte", Edad=21, IdEquipo=2},
                new Jugador{NombreJugador="Erwin Sánchez", Edad=20, IdEquipo=2},
                new Jugador{NombreJugador="Marcelo Martins", Edad=20, IdEquipo=2},
                new Jugador{NombreJugador="Julio Cesar Baldivieso", Edad=21, IdEquipo=2},
                new Jugador{NombreJugador="Carlos Aragones", Edad=20, IdEquipo=2},
                new Jugador{NombreJugador="Maximo Alcocer", Edad=20, IdEquipo=2},
                new Jugador{NombreJugador="Marco Antonio Etcheverry", Edad=24, IdEquipo=2},
                new Jugador{NombreJugador="Miguel Aguilar", Edad=22, IdEquipo=2},
                new Jugador{NombreJugador="Juan Carlos Arce", Edad=23, IdEquipo=2},
            };
            foreach (var j in jugadores)
            {
                context.Jugadores.Add(j);
            }
            context.SaveChanges();
        }
    }
}
