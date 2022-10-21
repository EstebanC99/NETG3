
namespace Academia.UI.WindowsForms
{
    partial class ReportePlanesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlanDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecialidadDescripcion = new System.Windows.Forms.TextBox();
            this.dgPlanes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaterias = new System.Windows.Forms.TabPage();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.tabComisiones = new System.Windows.Forms.TabPage();
            this.dgMateriasPlan = new System.Windows.Forms.DataGridView();
            this.dgComisiones = new System.Windows.Forms.DataGridView();
            this.ComisionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionAnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionCantAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgAlumnosPlan = new System.Windows.Forms.DataGridView();
            this.AlumnoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.MateriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMaterias.SuspendLayout();
            this.tabAlumnos.SuspendLayout();
            this.tabComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriasPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComisiones)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnosPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtEspecialidadDescripcion, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPlanDescripcion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgPlanes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción de Plan:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlanDescripcion
            // 
            this.txtPlanDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPlanDescripcion.Location = new System.Drawing.Point(114, 3);
            this.txtPlanDescripcion.Name = "txtPlanDescripcion";
            this.txtPlanDescripcion.Size = new System.Drawing.Size(170, 20);
            this.txtPlanDescripcion.TabIndex = 1;
            this.txtPlanDescripcion.TextChanged += new System.EventHandler(this.filtroChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(340, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEspecialidadDescripcion
            // 
            this.txtEspecialidadDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEspecialidadDescripcion.Location = new System.Drawing.Point(416, 3);
            this.txtEspecialidadDescripcion.Name = "txtEspecialidadDescripcion";
            this.txtEspecialidadDescripcion.Size = new System.Drawing.Size(284, 20);
            this.txtEspecialidadDescripcion.TabIndex = 3;
            this.txtEspecialidadDescripcion.TextChanged += new System.EventHandler(this.filtroChanged);
            // 
            // dgPlanes
            // 
            this.dgPlanes.AllowUserToAddRows = false;
            this.dgPlanes.AllowUserToDeleteRows = false;
            this.dgPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.EspecialidadDescripcion});
            this.tableLayoutPanel1.SetColumnSpan(this.dgPlanes, 5);
            this.dgPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPlanes.Location = new System.Drawing.Point(3, 29);
            this.dgPlanes.MultiSelect = false;
            this.dgPlanes.Name = "dgPlanes";
            this.dgPlanes.ReadOnly = true;
            this.dgPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlanes.Size = new System.Drawing.Size(697, 150);
            this.dgPlanes.TabIndex = 4;
            this.dgPlanes.SelectionChanged += new System.EventHandler(this.PlanSelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Plan";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 53;
            // 
            // EspecialidadDescripcion
            // 
            this.EspecialidadDescripcion.DataPropertyName = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.HeaderText = "Especialidad";
            this.EspecialidadDescripcion.Name = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.ReadOnly = true;
            this.EspecialidadDescripcion.Width = 92;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 5);
            this.tabControl1.Controls.Add(this.tabMaterias);
            this.tabControl1.Controls.Add(this.tabAlumnos);
            this.tabControl1.Controls.Add(this.tabComisiones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 205);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 484);
            this.tabControl1.TabIndex = 5;
            // 
            // tabMaterias
            // 
            this.tabMaterias.Controls.Add(this.dgMateriasPlan);
            this.tabMaterias.Location = new System.Drawing.Point(4, 22);
            this.tabMaterias.Name = "tabMaterias";
            this.tabMaterias.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterias.Size = new System.Drawing.Size(689, 458);
            this.tabMaterias.TabIndex = 0;
            this.tabMaterias.Text = "Materias";
            this.tabMaterias.UseVisualStyleBackColor = true;
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.tableLayoutPanel2);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumnos.Size = new System.Drawing.Size(689, 458);
            this.tabAlumnos.TabIndex = 1;
            this.tabAlumnos.Text = "Alumnos";
            this.tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // tabComisiones
            // 
            this.tabComisiones.Controls.Add(this.dgComisiones);
            this.tabComisiones.Location = new System.Drawing.Point(4, 22);
            this.tabComisiones.Name = "tabComisiones";
            this.tabComisiones.Size = new System.Drawing.Size(689, 458);
            this.tabComisiones.TabIndex = 2;
            this.tabComisiones.Text = "Comisiones";
            this.tabComisiones.UseVisualStyleBackColor = true;
            // 
            // dgMateriasPlan
            // 
            this.dgMateriasPlan.AllowUserToAddRows = false;
            this.dgMateriasPlan.AllowUserToDeleteRows = false;
            this.dgMateriasPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMateriasPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriasPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaID,
            this.MateriaDescripcion,
            this.HsSemanales,
            this.HsTotales});
            this.dgMateriasPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMateriasPlan.Location = new System.Drawing.Point(3, 3);
            this.dgMateriasPlan.MultiSelect = false;
            this.dgMateriasPlan.Name = "dgMateriasPlan";
            this.dgMateriasPlan.ReadOnly = true;
            this.dgMateriasPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMateriasPlan.Size = new System.Drawing.Size(683, 452);
            this.dgMateriasPlan.TabIndex = 5;
            // 
            // dgComisiones
            // 
            this.dgComisiones.AllowUserToAddRows = false;
            this.dgComisiones.AllowUserToDeleteRows = false;
            this.dgComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComisionID,
            this.ComisionDescripcion,
            this.ComisionAnioEspecialidad,
            this.ComisionCantAlumnos});
            this.dgComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgComisiones.Location = new System.Drawing.Point(0, 0);
            this.dgComisiones.MultiSelect = false;
            this.dgComisiones.Name = "dgComisiones";
            this.dgComisiones.ReadOnly = true;
            this.dgComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgComisiones.Size = new System.Drawing.Size(689, 458);
            this.dgComisiones.TabIndex = 7;
            // 
            // ComisionID
            // 
            this.ComisionID.DataPropertyName = "ComisionID";
            this.ComisionID.HeaderText = "ID";
            this.ComisionID.Name = "ComisionID";
            this.ComisionID.ReadOnly = true;
            this.ComisionID.Visible = false;
            this.ComisionID.Width = 43;
            // 
            // ComisionDescripcion
            // 
            this.ComisionDescripcion.DataPropertyName = "ComisionDescripcion";
            this.ComisionDescripcion.HeaderText = "Comision";
            this.ComisionDescripcion.Name = "ComisionDescripcion";
            this.ComisionDescripcion.ReadOnly = true;
            this.ComisionDescripcion.Width = 74;
            // 
            // ComisionAnioEspecialidad
            // 
            this.ComisionAnioEspecialidad.DataPropertyName = "ComisionAnioEspecialidad";
            this.ComisionAnioEspecialidad.HeaderText = "Año Especialidad";
            this.ComisionAnioEspecialidad.Name = "ComisionAnioEspecialidad";
            this.ComisionAnioEspecialidad.ReadOnly = true;
            this.ComisionAnioEspecialidad.Width = 105;
            // 
            // ComisionCantAlumnos
            // 
            this.ComisionCantAlumnos.DataPropertyName = "ComisionCantAlumnos";
            this.ComisionCantAlumnos.HeaderText = "Cant. Alumnos";
            this.ComisionCantAlumnos.Name = "ComisionCantAlumnos";
            this.ComisionCantAlumnos.ReadOnly = true;
            this.ComisionCantAlumnos.Width = 92;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgAlumnosPlan, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAlumno, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(683, 452);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dgAlumnosPlan
            // 
            this.dgAlumnosPlan.AllowUserToAddRows = false;
            this.dgAlumnosPlan.AllowUserToDeleteRows = false;
            this.dgAlumnosPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAlumnosPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnosPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlumnoID,
            this.AlumnoNombre,
            this.AlumnoApellido,
            this.AlumnoLegajo,
            this.AlumnoEmail,
            this.AlumnoTelefono});
            this.tableLayoutPanel2.SetColumnSpan(this.dgAlumnosPlan, 2);
            this.dgAlumnosPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAlumnosPlan.Location = new System.Drawing.Point(3, 29);
            this.dgAlumnosPlan.MultiSelect = false;
            this.dgAlumnosPlan.Name = "dgAlumnosPlan";
            this.dgAlumnosPlan.ReadOnly = true;
            this.dgAlumnosPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlumnosPlan.Size = new System.Drawing.Size(677, 420);
            this.dgAlumnosPlan.TabIndex = 7;
            // 
            // AlumnoID
            // 
            this.AlumnoID.DataPropertyName = "AlumnoID";
            this.AlumnoID.HeaderText = "ID";
            this.AlumnoID.Name = "AlumnoID";
            this.AlumnoID.ReadOnly = true;
            this.AlumnoID.Visible = false;
            this.AlumnoID.Width = 43;
            // 
            // AlumnoNombre
            // 
            this.AlumnoNombre.DataPropertyName = "AlumnoNombre";
            this.AlumnoNombre.HeaderText = "Nombre";
            this.AlumnoNombre.Name = "AlumnoNombre";
            this.AlumnoNombre.ReadOnly = true;
            this.AlumnoNombre.Width = 69;
            // 
            // AlumnoApellido
            // 
            this.AlumnoApellido.DataPropertyName = "AlumnoApellido";
            this.AlumnoApellido.HeaderText = "Apellido";
            this.AlumnoApellido.Name = "AlumnoApellido";
            this.AlumnoApellido.ReadOnly = true;
            this.AlumnoApellido.Width = 69;
            // 
            // AlumnoLegajo
            // 
            this.AlumnoLegajo.DataPropertyName = "AlumnoLegajo";
            this.AlumnoLegajo.HeaderText = "Legajo";
            this.AlumnoLegajo.Name = "AlumnoLegajo";
            this.AlumnoLegajo.ReadOnly = true;
            this.AlumnoLegajo.Width = 64;
            // 
            // AlumnoEmail
            // 
            this.AlumnoEmail.DataPropertyName = "AlumnoEmail";
            this.AlumnoEmail.HeaderText = "Email";
            this.AlumnoEmail.Name = "AlumnoEmail";
            this.AlumnoEmail.ReadOnly = true;
            this.AlumnoEmail.Width = 57;
            // 
            // AlumnoTelefono
            // 
            this.AlumnoTelefono.DataPropertyName = "AlumnoTelefono";
            this.AlumnoTelefono.HeaderText = "Telefono";
            this.AlumnoTelefono.Name = "AlumnoTelefono";
            this.AlumnoTelefono.ReadOnly = true;
            this.AlumnoTelefono.Width = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alumno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAlumno.Location = new System.Drawing.Point(54, 3);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(626, 20);
            this.txtAlumno.TabIndex = 9;
            this.txtAlumno.TextChanged += new System.EventHandler(this.FiltroAlumnoChanged);
            // 
            // MateriaID
            // 
            this.MateriaID.DataPropertyName = "MateriaID";
            this.MateriaID.HeaderText = "ID";
            this.MateriaID.Name = "MateriaID";
            this.MateriaID.ReadOnly = true;
            this.MateriaID.Visible = false;
            this.MateriaID.Width = 43;
            // 
            // MateriaDescripcion
            // 
            this.MateriaDescripcion.DataPropertyName = "MateriaDescripcion";
            this.MateriaDescripcion.HeaderText = "Materia";
            this.MateriaDescripcion.Name = "MateriaDescripcion";
            this.MateriaDescripcion.ReadOnly = true;
            this.MateriaDescripcion.Width = 67;
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HsSemanales";
            this.HsSemanales.HeaderText = "Hs. Semanales";
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            this.HsSemanales.Width = 95;
            // 
            // HsTotales
            // 
            this.HsTotales.DataPropertyName = "HsTotales";
            this.HsTotales.HeaderText = "Hs. Totales";
            this.HsTotales.Name = "HsTotales";
            this.HsTotales.ReadOnly = true;
            this.HsTotales.Width = 79;
            // 
            // ReportePlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportePlanesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePlanesForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMaterias.ResumeLayout(false);
            this.tabAlumnos.ResumeLayout(false);
            this.tabComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriasPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComisiones)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnosPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEspecialidadDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlanDescripcion;
        private System.Windows.Forms.DataGridView dgPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadDescripcion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaterias;
        private System.Windows.Forms.DataGridView dgMateriasPlan;
        private System.Windows.Forms.TabPage tabAlumnos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgAlumnosPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoTelefono;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TabPage tabComisiones;
        private System.Windows.Forms.DataGridView dgComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionAnioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionCantAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
    }
}