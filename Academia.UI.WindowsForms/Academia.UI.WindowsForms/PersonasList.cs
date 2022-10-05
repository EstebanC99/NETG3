using Academia.UI.Services;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class PersonasList : Form
    {
        private IPersonaUIService UIService { get; set; }

        private PersonaFiltroVM FiltroVM { get; set; }

        public PersonasList(IPersonaUIService uiService)
        {
            InitializeComponent();

            this.UIService = uiService;
            this.FiltroVM = new PersonaFiltroVM();

            this.dgPersonas.AutoGenerateColumns = false;
            this.dgPersonas.DataSource = this.UIService.LeerTodas();
        }

        public PersonasList() : this(IoCContainer.Instance.TryResolve<IPersonaUIService>())
        {

        }

        private void dgPersonas_DoubleClick(object sender, EventArgs e)
        {
            var usuariosDesktop = (UsuarioDesktop)this.Owner;

            var personaID = int.Parse(this.dgPersonas.SelectedRows[0].Cells[0].Value.ToString());

            usuariosDesktop.RecuperarPersonaElegida(this.UIService.LeerPorID(personaID));

            this.Close();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            this.FiltroVM.Descripcion = this.txtNombreApellido.Text;

            this.dgPersonas.DataSource = this.UIService.BuscarPorPatron(this.FiltroVM);
        }
    }
}
