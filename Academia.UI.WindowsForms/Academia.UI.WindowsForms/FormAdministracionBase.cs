using Academia.UI.Globals;
using Academia.UI.Services;
using Security.Desktop;
using System;
using System.Collections.Generic;
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

        protected void DesactivarMenuTsb(ToolStrip tsb)
        {
            tsb.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
        }
    }
}
