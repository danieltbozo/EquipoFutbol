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
                new Jugador{IdJugador=1, NombreJugador="Lionel Messi", Edad=24, IdEquipo=1},
                new Jugador{IdJugador=2, NombreJugador="Hernán Crespo", Edad=21, IdEquipo=1},
                new Jugador{IdJugador=3, NombreJugador="Gabriel Omar Batistuta", Edad=20, IdEquipo=1},
                new Jugador{IdJugador=4, NombreJugador="Gonzalo Higuain", Edad=20, IdEquipo=1},
                new Jugador{IdJugador=5, NombreJugador="Sergio Aguero", Edad=21, IdEquipo=1},
                new Jugador{IdJugador=6, NombreJugador="Ariel Ortega", Edad=20, IdEquipo=1},
                new Jugador{IdJugador=7, NombreJugador="Claudio Javier López", Edad=20, IdEquipo=1},
                new Jugador{IdJugador=8, NombreJugador="Juan Román Riquelme", Edad=24, IdEquipo=1},
                new Jugador{IdJugador=9, NombreJugador="Oreste Corbatta", Edad=22, IdEquipo=1},
                new Jugador{IdJugador=10, NombreJugador="Juan Sebastián Vero", Edad=23, IdEquipo=1},

                new Jugador{IdJugador=11, NombreJugador="Joaquín Botero", Edad=24, IdEquipo=2},
                new Jugador{IdJugador=12, NombreJugador="Victor Agustín Ugarte", Edad=21, IdEquipo=2},
                new Jugador{IdJugador=13, NombreJugador="Erwin Sánchez", Edad=20, IdEquipo=2},
                new Jugador{IdJugador=14, NombreJugador="Marcelo Martins", Edad=20, IdEquipo=2},
                new Jugador{IdJugador=15, NombreJugador="Julio Cesar Baldivieso", Edad=21, IdEquipo=2},
                new Jugador{IdJugador=16, NombreJugador="Carlos Aragones", Edad=20, IdEquipo=2},
                new Jugador{IdJugador=17, NombreJugador="Maximo Alcocer", Edad=20, IdEquipo=2},
                new Jugador{IdJugador=18, NombreJugador="Marco Antonio Etcheverry", Edad=24, IdEquipo=2},
                new Jugador{IdJugador=19, NombreJugador="Miguel Aguilar", Edad=22, IdEquipo=2},
                new Jugador{IdJugador=20, NombreJugador="Juan Carlos Arce", Edad=23, IdEquipo=2},
            };
            foreach (var j in jugadores)
            {
                context.Jugadores.Add(j);
            }
            context.SaveChanges();
        }
    }
}
