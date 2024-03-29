﻿using Academia.UI.Globals;
using Academia.UI.Services;
using Academia.UI.Services.Materias;
using Academia.UI.Services.Personas.Administradores;
using Business.Utils;
using Security.Desktop;
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

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias(IoCContainer.Instance.TryResolve<IMateriaUIService>());

            materias.ShowDialog();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones comisiones = new Comisiones(IoCContainer.Instance.TryResolve<IComisionUIService>());

            comisiones.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos(IoCContainer.Instance.TryResolve<ICursoUIService>());

            cursos.ShowDialog();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administradores administradores = new Administradores(IoCContainer.Instance.TryResolve<IAdministradorUIService>());

            administradores.ShowDialog();
        }

        private void SolicitarCredenciales()
        {
            var loging = new Login().ShowDialog();

            if (!SessionInfo.Instance.EstaLogeado)
                this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.SolicitarCredenciales();

            this.HabilitarMenues();
        }

        private void HabilitarMenues()
        {
            this.administradoresToolStripMenuItem.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
            this.alumnosToolStripMenuItem.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
            this.comisionesToolStripMenuItem.Enabled = SessionInfo.Instance.EstaLogeado && (SessionInfo.Instance.UserRolID == RolesUsuario.Administrador || SessionInfo.Instance.UserRolID == RolesUsuario.Profesor);
            this.profesoresToolStripMenuItem.Enabled = SessionInfo.Instance.EstaLogeado && (SessionInfo.Instance.UserRolID == RolesUsuario.Administrador || SessionInfo.Instance.UserRolID == RolesUsuario.Profesor);
            this.usuariosToolStripMenuItem.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
            this.asignarProfesoresBtn.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
            this.tsReporteCursos.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
            this.tsbReportePlanes.Enabled = SessionInfo.Instance.EstaLogeado && SessionInfo.Instance.UserRolID == RolesUsuario.Administrador;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Seguro que desea salir?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                SessionInfo.Instance.LimpiarSession();

                this.SolicitarCredenciales();

                this.HabilitarMenues();
            }

            return;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AsignarCursoDesktop asignarCurso = new AsignarCursoDesktop();

            asignarCurso.ShowDialog();
        }

        private void tsReporteCursos_Click(object sender, EventArgs e)
        {
            ReporteCursosForm reporteCursosForm = new ReporteCursosForm();

            reporteCursosForm.ShowDialog();
        }

        private void tsbReportePlanes_Click(object sender, EventArgs e)
        {
            ReportePlanesForm reportePlanesForm = new ReportePlanesForm();

            reportePlanesForm.ShowDialog();
        }
    }
}
