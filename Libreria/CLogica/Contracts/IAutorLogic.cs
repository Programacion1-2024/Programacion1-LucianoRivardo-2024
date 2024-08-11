using CEntidades.Entidades;


namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        Task<List<Autor>> GetAll();
        void CrearAutor(Autor autor);
        void ModificarAutor(string DocumentoAutor,Autor autor);
        Autor ObtenerAutor(string DocumentoAutor);
        void EliminarAutor(string DocumentoAutor);
    }
}
