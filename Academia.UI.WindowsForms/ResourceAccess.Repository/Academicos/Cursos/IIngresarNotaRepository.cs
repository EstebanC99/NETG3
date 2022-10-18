using Business.Views.Cursos;

namespace ResourceAccess.Repository.Academicos.Cursos
{
    public interface IIngresarNotaRepository : IRepository
    {
        InscripcionDataView LeerInscripcionPorID(int inscripcionID);
    }
}