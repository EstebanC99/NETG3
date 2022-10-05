
namespace Academia.UI.WindowsForms
{
    partial class AsignarCursoDesktop
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
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgProfesoresAsignados = new System.Windows.Forms.DataGridView();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesoresAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgCursos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgProfesoresAsignados, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToAddRows = false;
            this.dgCursos.AllowUserToDeleteRows = false;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MateriaDescripcion,
            this.PlanDescripcion,
            this.EspecialidadDescripcion,
            this.AnioCalendario});
            this.tableLayoutPanel1.SetColumnSpan(this.dgCursos, 2);
            this.dgCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCursos.Location = new System.Drawing.Point(3, 23);
            this.dgCursos.MultiSelect = false;
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCursos.Size = new System.Drawing.Size(810, 248);
            this.dgCursos.TabIndex = 1;
            this.dgCursos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCursos_RowEnter);
            this.dgCursos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCursos_KeyPress);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // MateriaDescripcion
            // 
            this.MateriaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MateriaDescripcion.DataPropertyName = "MateriaDescripcion";
            this.MateriaDescripcion.HeaderText = "Materia";
            this.MateriaDescripcion.Name = "MateriaDescripcion";
            this.MateriaDescripcion.ReadOnly = true;
            this.MateriaDescripcion.Width = 67;
            // 
            // PlanDescripcion
            // 
            this.PlanDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlanDescripcion.DataPropertyName = "PlanDescripcion";
            this.PlanDescripcion.HeaderText = "Plan";
            this.PlanDescripcion.Name = "PlanDescripcion";
            this.PlanDescripcion.ReadOnly = true;
            this.PlanDescripcion.Width = 53;
            // 
            // EspecialidadDescripcion
            // 
            this.EspecialidadDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EspecialidadDescripcion.DataPropertyName = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.HeaderText = "Especialidad";
            this.EspecialidadDescripcion.Name = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.ReadOnly = true;
            this.EspecialidadDescripcion.Width = 92;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            this.AnioCalendario.Width = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profesores asignados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(3, 424);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+ Agregar profesor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgProfesoresAsignados
            // 
            this.dgProfesoresAsignados.AllowUserToAddRows = false;
            this.dgProfesoresAsignados.AllowUserToDeleteRows = false;
            this.dgProfesoresAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesoresAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfesorID,
            this.ProfesorNombre,
            this.ProfesorApellido,
            this.ProfesorLegajo,
            this.Cargo});
            this.tableLayoutPanel1.SetColumnSpan(this.dgProfesoresAsignados, 2);
            this.dgProfesoresAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProfesoresAsignados.Location = new System.Drawing.Point(3, 297);
            this.dgProfesoresAsignados.Name = "dgProfesoresAsignados";
            this.dgProfesoresAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesoresAsignados.Size = new System.Drawing.Size(810, 121);
            this.dgProfesoresAsignados.TabIndex = 4;
            this.dgProfesoresAsignados.DataSourceChanged += new System.EventHandler(this.dgProfesoresAsignados_DataSourceChanged);
            // 
            // ProfesorID
            // 
            this.ProfesorID.DataPropertyName = "ProfesorID";
            this.ProfesorID.HeaderText = "ID";
            this.ProfesorID.Name = "ProfesorID";
            this.ProfesorID.ReadOnly = true;
            this.ProfesorID.Visible = false;
            // 
            // ProfesorNombre
            // 
            this.ProfesorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfesorNombre.DataPropertyName = "ProfesorNombre";
            this.ProfesorNombre.HeaderText = "Nombre";
            this.ProfesorNombre.Name = "ProfesorNombre";
            this.ProfesorNombre.ReadOnly = true;
            this.ProfesorNombre.Width = 69;
            // 
            // ProfesorApellido
            // 
            this.ProfesorApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfesorApellido.DataPropertyName = "ProfesorApellido";
            this.ProfesorApellido.HeaderText = "Apellido";
            this.ProfesorApellido.Name = "ProfesorApellido";
            this.ProfesorApellido.ReadOnly = true;
            this.ProfesorApellido.Width = 69;
            // 
            // ProfesorLegajo
            // 
            this.ProfesorLegajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfesorLegajo.DataPropertyName = "ProfesorLegajo";
            this.ProfesorLegajo.HeaderText = "Legajo";
            this.ProfesorLegajo.Name = "ProfesorLegajo";
            this.ProfesorLegajo.ReadOnly = true;
            this.ProfesorLegajo.Width = 64;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 60;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(192, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // AsignarCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "AsignarCursoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignar Profesores a Cursos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesoresAsignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgProfesoresAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.Button btnEliminar;
    }
}