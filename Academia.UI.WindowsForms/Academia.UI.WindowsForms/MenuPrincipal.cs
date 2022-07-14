using Academia.UI.Services;
using Business.Utils;
using System;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores(IoCContainer.Instance.TryResolve<IProfesorUIService>());

            profesores.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos(IoCContainer.Instance.TryResolve<IAlumnoUIService>());

            alumnos.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(IoCContainer.Instance.TryResolve<IUsuarioUIService>());

            usuarios.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades especialidades = new Especialidades(IoCContainer.Instance.TryResolve<IEspecialidadUIService>());

            especialidades.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes(IoCContainer.Instance.TryResolve<IPlanUIService>());

            planes.ShowDialog();
        }
    }
}
