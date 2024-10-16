using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EditorialLogic : IEditorialLogic
    {
        private IEditorialRepository _editorialRepository;
        public EditorialLogic(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }

        public void AltaEditorial(string nombre, string contacto, string direccion)
        {

            try
            {
                Editorial nuevaEditorial = new Editorial()
                {
                    Nombre = nombre,
                    Contacto = contacto,
                    Direccion = direccion,
                    
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(nombre))
                {
                    camposErroneos.Add("Nombre");
                }
                if (string.IsNullOrEmpty(direccion))
                {
                    camposErroneos.Add("Direccion");
                }
                if (string.IsNullOrEmpty(contacto) ||!ValidacionesLogic.TelefonoEsValido(contacto))
                {
                    camposErroneos.Add("Contacto");
                }
                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: "+ string.Join(", ", camposErroneos));
                }
                _editorialRepository.Create(nuevaEditorial);
                _editorialRepository.Save();
         
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ModificarEditorial(string id, string nombre, string contacto, string direccion)
        {
            try
            {
                
                var editorialExistente = _editorialRepository.GetById(Int32.Parse(id));
                if (editorialExistente == null)
                {
                    throw new KeyNotFoundException("La editorial no fue encontrada.");
                }

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(nombre))
                {
                    camposErroneos.Add("Nombre");
                }
                if (string.IsNullOrEmpty(contacto) || !ValidacionesLogic.TelefonoEsValido(contacto))
                {
                    camposErroneos.Add("Contacto");
                }
                if (string.IsNullOrEmpty(direccion))
                {
                    camposErroneos.Add("Direccion");
                }


                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
                }

                editorialExistente.Nombre = nombre;
                editorialExistente.Contacto = contacto;
                editorialExistente.Direccion = direccion;
                

                _editorialRepository.Update(editorialExistente);
                _editorialRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void BajaEditorial(string id)
        {
            try
            {
                var editorialExistente = _editorialRepository.GetById(Int32.Parse(id));
                if (editorialExistente == null)
                {
                    throw new KeyNotFoundException("La editorial no fue encontrada.");
                }

                _editorialRepository.Delete(editorialExistente);
                _editorialRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Editorial> ObtenerEditorilesParaListado()
        {
            return _editorialRepository.GetAll();
            //var editoriales = _editorialRepository.ObtenerEditoriales();

            //return editoriales.Select(a => new
            //{
            //    IdEditorial = a.IdEditorial,
            //    Nombre = a.Nombre,
            //    Direccion = a.Direccion,
            //    Contacto = a.Contacto

            //}).ToList<dynamic>(); // Convierte a lista dinámica
        }
        public Editorial ObtenerEditorialPorId(string id)
        {
            // Suponiendo que tienes un contexto de base de datos
            return _editorialRepository.GetById(Int32.Parse(id));
        }
    }
}
