using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Contexts;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace CLogica.Metodos
{
    internal class CRUDpersona
    {
        LibreriaContext context = new LibreriaContext();
        public void AgregaPersona(Persona personaNueva)
        {
            Persona persona = new Persona();
            persona.Nombre = personaNueva.Nombre;
            persona.Apellido = personaNueva.Apellido;
            persona.Nacionalidad = personaNueva.Nacionalidad;
            persona.Documento = personaNueva.Documento;
            persona.TipoDocumento = personaNueva.TipoDocumento;
            persona.Telefono = personaNueva.Telefono;
            persona.Email = personaNueva.Email;
            if (persona.Autor != null)
            {
                persona.Autor = personaNueva.Autor;
            }
            if (persona.Empleado != null)
            {
                persona.Empleado = personaNueva.Empleado;
            }
            if (persona.Cliente != null)
            {
                persona.Cliente = personaNueva.Cliente;
            }
            context.Persona.Update(persona);
            context.SaveChanges();
        }
        public void ModificarPersona(Persona personaBuscada, Persona personaNueva)
        {
            personaBuscada.Telefono = personaNueva.Telefono;
            personaBuscada.Email = personaNueva.Email;
            context.Persona.Update(personaBuscada);
            context.SaveChanges();

        }
        public void EliminarPersona(Persona personaBuscada)
        {
            context.Persona.Remove(personaBuscada);
        }
        public void ConsultarPersona(string documento)
        {
            context.Persona.FirstOrDefault(p => p.Documento == documento);
        }
    }
}
