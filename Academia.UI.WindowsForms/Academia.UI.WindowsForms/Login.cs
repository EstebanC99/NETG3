using Academia.UI.Services.Usuarios;
using Academia.UI.ViewModels;
using Business.Utils;
using Security.Desktop;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class Login : Form
    {
        private ILoginUIService UIService { get; set; }
        
        private LoginVM Model { get; set; }

        public Login(ILoginUIService uiService)
        {
            InitializeComponent();

            this.UIService = uiService;
            this.Model = new LoginVM();
        }

        public Login() : this(IoCContainer.Instance.TryResolve<ILoginUIService>())
        {

        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtUsername.Text))
            {
                return;
            }

            this.Model.Username = this.txtUsername.Text;
            this.Model.Password = this.txtPassword.Text;

            var usuario = this.UIService.Login(this.Model);

            this.Model.ID = usuario.ID;
            this.Model.RolUsuarioID = usuario.RolUsuarioID;

            SessionInfo.Instance.SetInfo(this.Model.ID, this.Model.Username, this.Model.RolUsuarioID);

            this.Close();
        }
    }
}
