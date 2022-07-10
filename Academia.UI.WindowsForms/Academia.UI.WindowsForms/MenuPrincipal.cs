using Business.Logic;
using Business.Logic.Interfaces;
using Business.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.WindowsForms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores(IoCContainer.Instance.TryResolve<IProfesorLogic>());

            profesores.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos(IoCContainer.Instance.TryResolve<IAlumnoLogic>());

            alumnos.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(IoCContainer.Instance.TryResolve<IUsuarioLogic>());

            usuarios.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades especialidades = new Especialidades(IoCContainer.Instance.TryResolve<IEspecialidadLogic>());

            especialidades.ShowDialog();
        }
    }
}
