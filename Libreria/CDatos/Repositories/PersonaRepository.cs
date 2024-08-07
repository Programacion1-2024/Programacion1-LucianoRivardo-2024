using CDatos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using CDatos.Contexts;

namespace CDatos.Repositories
{
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        public PersonaRepository(LibreriaContext context): base(context)
        {

        }
    }
}
