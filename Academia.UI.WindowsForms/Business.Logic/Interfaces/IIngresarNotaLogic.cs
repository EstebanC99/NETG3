using Business.Views.Cursos;

namespace Business.Logic.Interfaces
{
    public interface IIngresarNotaLogic : ILogicBase
    {
        InscripcionDataView LeerInscripcionPorID(int inscripcionID);

        void RegistrarNota(InscripcionDataView inscripcion);
    }
}