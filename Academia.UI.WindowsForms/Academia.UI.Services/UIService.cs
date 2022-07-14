using Academia.UI.ViewModels;
using Business.Logic;
using System;

namespace Academia.UI.Services
{
    public class UIService<TLogicBase,TViewModel> : IUIService<TViewModel>
        where TLogicBase : ILogicBase
        where TViewModel : ViewModel, new()
    {
        protected TLogicBase Logic { get; private set; }

        protected UIService(TLogicBase logic)
        {
            this.Logic = logic;
        }

        public virtual void Registrar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public virtual void Modificar(TViewModel model) { throw new NotImplementedException(); }

        public virtual void Eliminar(TViewModel model) { throw new NotImplementedException(); }
    }
}
