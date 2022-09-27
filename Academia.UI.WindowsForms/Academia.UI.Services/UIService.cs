using Academia.UI.ViewModels;
using Business.Logic;
using System;

namespace Academia.UI.Services
{
    public class UIService<TLogicBase>: IUIService
        where TLogicBase: ILogicBase
    {
        protected TLogicBase Logic { get; private set; }

        protected UIService(TLogicBase logic)
        {
            this.Logic = logic;
        }
    }

    public class UIService<TLogicBase,TViewModel> : UIService<TLogicBase>, IUIService<TViewModel>
        where TLogicBase : ILogicBase
        where TViewModel : ViewModel, new()
    {
        protected UIService(TLogicBase logic) : base(logic)
        {
        }

        public virtual void Registrar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public virtual void Modificar(TViewModel model) { throw new NotImplementedException(); }

        public virtual void Eliminar(TViewModel model) { throw new NotImplementedException(); }
    }
}
