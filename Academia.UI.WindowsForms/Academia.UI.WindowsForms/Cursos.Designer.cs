
namespace Academia.UI.WindowsForms
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tsPlanes = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tsPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvCursos);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 430);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsPlanes);
            // 
            // tsPlanes
            // 
            this.tsPlanes.AutoSize = false;
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsPlanes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsPlanes.Location = new System.Drawing.Point(3, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(147, 20);
            this.tsPlanes.TabIndex = 10;
            this.tsPlanes.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(24, 17);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(24, 17);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(24, 17);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AnioCalendario,
            this.Cupo,
            this.MateriaID,
            this.MateriaDescripcion,
            this.ComisionID,
            this.ComisionDescripcion});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(800, 430);
            this.dgvCursos.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // MateriaID
            // 
            this.MateriaID.DataPropertyName = "MateriaID";
            this.MateriaID.HeaderText = "MateriaID";
            this.MateriaID.Name = "MateriaID";
            this.MateriaID.ReadOnly = true;
            this.MateriaID.Visible = false;
            // 
            // MateriaDescripcion
            // 
            this.MateriaDescripcion.DataPropertyName = "MateriaDescripcion";
            this.MateriaDescripcion.HeaderText = "Materia";
            this.MateriaDescripcion.Name = "MateriaDescripcion";
            this.MateriaDescripcion.ReadOnly = true;
            // 
            // ComisionID
            // 
            this.ComisionID.DataPropertyName = "ComisionID";
            this.ComisionID.HeaderText = "ComisionID";
            this.ComisionID.Name = "ComisionID";
            this.ComisionID.ReadOnly = true;
            this.ComisionID.Visible = false;
            // 
            // ComisionDescripcion
            // 
            this.ComisionDescripcion.DataPropertyName = "ComisionDescripcion";
            this.ComisionDescripcion.HeaderText = "Comision";
            this.ComisionDescripcion.Name = "ComisionDescripcion";
            this.ComisionDescripcion.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip tsPlanes;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionDescripcion;
    }
}