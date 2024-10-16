using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class EditorialRepository : Repository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(LibreriaContext context) : base(context)
        {

        }

        public List<Editorial> ObtenerEditoriales()
        {
            return _context.Set<Editorial>().ToList(); // Asegúrate de que el tipo sea Editorial
        }
        public List<Editorial> GetAll()
        {
            // Utilizamos Entity Framework para obtener todas las editoriales
            return _context.Editorial.ToList();
        }
        //public List<Editorial> ObtenerEditoriales()
        //{
        //    return _context.Editorial.Include(a => a.IdEditorial).ToList();
        //}
    }
}
