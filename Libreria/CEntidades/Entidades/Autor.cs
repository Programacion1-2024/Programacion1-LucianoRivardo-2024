﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Autor : Persona
    {
        public int IdAutor { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Persona PersonaAutor { get; set; }
        public ICollection<Libro> Libros {  get; set; } 
    }
}
