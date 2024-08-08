using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        public AutorLogic(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<List<Autor>> GetAll()
        {
            return await _autorRepository.GetAll();
        }

        public void AgregarAutor(Autor autorNuevo)
        {
            Autor autor = new Autor();
            autor.Biografia = autorNuevo.Biografia;
            autor.FechaNacimiento = autorNuevo.FechaNacimiento;
            autor.PersonaAutor = autorNuevo.PersonaAutor;
            autor.Libros = autorNuevo.Libros;   
        }
    }
}
