using Academia.UI.ViewModels;

namespace Academia.UI.Services.Cursos
{
    public interface IIngresarNotaUIService : IUIService
    {
        InscripcionVM LeerInscripcionPorID(int inscripcionID);

        void IngresarNota(InscripcionVM inscripcion);
    }
}