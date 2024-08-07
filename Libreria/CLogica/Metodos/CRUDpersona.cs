using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Contexts;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using CLogica.Metodos;

namespace CLogica.Metodos
{
    internal class CRUDpersona
    {
        LibreriaContext context = new LibreriaContext();
        public void AgregaPersona(Persona personaNueva)
        {
            if (string.IsNullOrEmpty(personaNueva.Nombre) || !IsValidName(personaNueva.Nombre))
                throw new ArgumentException("Nombre inválido");

            if (string.IsNullOrEmpty(personaNueva.Apellido) || !IsValidName(personaNueva.Apellido))
                throw new ArgumentException("Apellido inválido");

            if (string.IsNullOrEmpty(personaNueva.Documento) || !IsValidDocumento(personaNueva.Documento))
                throw new ArgumentException("Documento inválido");

            if (string.IsNullOrEmpty(personaNueva.Telefono) || !IsValidTelefono(personaNueva.Telefono))
                throw new ArgumentException("Teléfono inválido");

            if (string.IsNullOrEmpty(personaNueva.Email) || !IsValidEmail(personaNueva.Email))
                throw new ArgumentException("Email inválido");

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

        //VALIDACIONES PARA USAR EN LOS METODOS
        public bool IsValidName(string nombre)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            bool contieneCaracter = false;
            if (nombre.Length < 15)
            {
                foreach (char i in caracteres)
                {
                    if (nombre.Contains(i))
                    {
                        contieneCaracter = true;
                        break;
                    }
                }
            }
            return contieneCaracter;

        }

        public bool IsValidDocumento(string documento)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            bool contieneCaracter = false;
            if (documento.Length != 8)
            {
                return false;
            }
            else
            {
                foreach (char i in caracteres)
                {
                    if (documento.Contains(i))
                    {
                        contieneCaracter = true;
                        break;
                    }
                }
            }
            return contieneCaracter;
        }

        public bool IsValidTelefono(string telefono)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            bool contieneCaracter = false;
            if (telefono.Length != 10)
            {
                return false;
            }
            else
            {
                foreach (char i in caracteres)
                {
                    if (telefono.Contains(i))
                    {
                        contieneCaracter = true;
                        break;
                    }
                }
            }
            return contieneCaracter;
        }

        public bool IsValidEmail(string email)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            bool contieneCaracter = false;
            if (email.Contains('@'))
            {
                foreach (char i in caracteres)
                {
                    if (email.Contains(i))
                    {
                        contieneCaracter = true;
                        break;
                    }
                }
            }
            return contieneCaracter;
        }
    }
}

