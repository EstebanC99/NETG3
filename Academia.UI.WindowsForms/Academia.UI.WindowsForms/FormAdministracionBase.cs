using Academia.UI.Services;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class FormAdministracionBase<TUIService> : Form, IFormAdministracionBase
        where TUIService : IUIService
    {
        protected TUIService UIService { get; private set; }

        public FormAdministracionBase()
        {

        }

        public FormAdministracionBase(TUIService uiService) : base()
        {
            this.UIService = uiService;
        }
    }
}
