using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        void AgregarPersona(Persona persona);
        void ModificarPersona(string documento);
        void EliminarPersona(Persona persona);
    }
}
