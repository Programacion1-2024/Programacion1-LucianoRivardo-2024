using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEditorialLogic
    {
        void AltaEditorial(string nombre, string direccion, string contacto);
        void ModificarEditorial(string id, string nombre, string direccion, string contacto);
        void BajaEditorial(string id);
        public List<Editorial> ObtenerEditorilesParaListado();
        public Editorial ObtenerEditorialPorId(string id);
    }
}
