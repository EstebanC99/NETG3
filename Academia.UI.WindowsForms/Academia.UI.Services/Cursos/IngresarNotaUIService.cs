using Academia.UI.ViewModels;
using AutoMapper;
using Business.Logic.Interfaces;
using Business.Views.Cursos;

namespace Academia.UI.Services.Cursos
{
    public class IngresarNotaUIService : UIService<IIngresarNotaLogic>, IIngresarNotaUIService
    {
        public IngresarNotaUIService(IIngresarNotaLogic logic) : base(logic)
        {

        }

        public InscripcionVM LeerInscripcionPorID(int inscripcionID)
        {
            var inscripcion = this.Logic.LeerInscripcionPorID(inscripcionID);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<InscripcionDataView, InscripcionVM>());
            var mapper = new Mapper(mapperConfig);

            return mapper.Map<InscripcionVM>(inscripcion);
        }

        public void IngresarNota(InscripcionVM inscripcion)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<InscripcionVM, InscripcionDataView>());
            var mapper = new Mapper(mapperConfig);

            this.Logic.RegistrarNota(mapper.Map<InscripcionDataView>(inscripcion));
        }
    }
}
