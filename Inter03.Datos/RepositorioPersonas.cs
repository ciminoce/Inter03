using System;
using System.Collections.Generic;
using System.Linq;
using Inter03.Entidades;

namespace Inter03.Datos
{
    public class RepositorioPersonas
    {
        public List<Persona> GetGente()
        {
            var personas = new List<Persona>()
            {
                new Persona() { Id=1, Nombre="John", Apellido="Koenig",
                    FechaNacimiento = new DateTime(1975, 10, 17)},
                new Persona() { Id=2, Nombre="Dylan", Apellido="Hunt",
                    FechaNacimiento = new DateTime(2000, 10, 2) },
                new Persona() { Id=3, Nombre="Leela", Apellido="Turanga",
                    FechaNacimiento = new DateTime(1999, 3, 28) },
                new Persona() { Id=4, Nombre="John", Apellido="Crichton",
                    FechaNacimiento = new DateTime(1999, 3, 19) },
                new Persona() { Id=5, Nombre="Dave", Apellido="Lister",
                    FechaNacimiento = new DateTime(1988, 2, 15) },
                new Persona() { Id=6, Nombre="Laura", Apellido="Roslin",
                    FechaNacimiento = new DateTime(2003, 12, 8)},
                new Persona() { Id=7, Nombre="John", Apellido="Sheridan",
                    FechaNacimiento = new DateTime(1994, 1, 26) },
                new Persona() { Id=8, Nombre="Dante", Apellido="Montana",
                    FechaNacimiento = new DateTime(2000, 11, 1) },
                new Persona() { Id=9, Nombre="Isaac", Apellido="Gampu",
                    FechaNacimiento = new DateTime(1977, 9, 10) },
            };
            return personas;
        }

        public Persona GetPersoan(int id)
        {
            return GetGente().FirstOrDefault(p => p.Id == id);
        }

    }
}
