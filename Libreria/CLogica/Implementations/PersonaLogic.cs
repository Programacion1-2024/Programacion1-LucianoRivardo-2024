﻿using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLogica;
using Azure.Identity;
using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;

        public PersonaLogic(IPersonaRepository personaRepository) {
            _personaRepository = personaRepository;
        }
        public void AgregarPersona(Persona personaNueva)
        {

            if (DocumentoExistente(personaNueva.Documento)) 
                throw new ArgumentException("Documento ya existente");

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
            if (personaNueva.Autor != null)
            {
                persona.Autor = personaNueva.Autor;
            }
            if (personaNueva.Empleado != null)
            {
                persona.Empleado = personaNueva.Empleado;
            }
            if (personaNueva.Cliente != null)
            {
                persona.Cliente = personaNueva.Cliente;
            }
            _personaRepository.Create(persona);
            _personaRepository.Save();
        }

        public void ModificarPersona(string documento, Persona personaModificada)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("documento inválido");
            Persona? persona = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            if (persona == null)
            {
                throw new ArgumentNullException("no se encontro una persona con ese documento");
            }
            persona.Nombre = personaModificada.Nombre;
            persona.Apellido = personaModificada.Apellido;
            persona.Documento = personaModificada.Documento;
            persona.Telefono = personaModificada.Telefono;
            persona.Email = personaModificada.Email;

        }

        public void EliminarPersona(Persona persona)
        {
            _personaRepository.Delete(persona);
            _personaRepository.Save();
        }
        public bool ContieneCaracter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '.', ',', };
            return caracteres.Any(p => text.Contains(p));
        }
        private bool IsValidName(string nombre)
        {
            return ContieneCaracter(nombre) && nombre.Length < 15;
        }

        private bool IsValidDocumento(string documento)
        {
            return documento.Length != 8 && ContieneCaracter(documento);
        }

        private bool IsValidTelefono(string telefono)
        {
            return telefono.Length != 10 && ContieneCaracter(telefono);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@') && ContieneCaracter(email);
        }

        private bool DocumentoExistente(string documento)
        {
            var documentoExistente = _personaRepository
            .FindByCondition(p => p.Documento == documento)
            .FirstOrDefault();
            return documentoExistente != null;
        }

    } 
}
