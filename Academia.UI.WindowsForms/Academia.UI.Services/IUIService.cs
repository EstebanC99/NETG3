using Academia.UI.ViewModels;

namespace Academia.UI.Services
{
    public interface IUIService { }

    public interface IUIService<TViewModel> : IUIService
        where TViewModel : ViewModel
    {
        void Registrar(TViewModel model);

        void Modificar(TViewModel model);

        void Eliminar(TViewModel model);
    }
}