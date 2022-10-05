
namespace Academia.UI.WindowsForms
{
    partial class ProfesoresList
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
            this.dgProfesores = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProfesores
            // 
            this.dgProfesores.AllowUserToAddRows = false;
            this.dgProfesores.AllowUserToDeleteRows = false;
            this.dgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfesorID,
            this.ProfesorNombre,
            this.ProfesorApellido,
            this.ProfesorLegajo});
            this.tableLayoutPanel1.SetColumnSpan(this.dgProfesores, 2);
            this.dgProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProfesores.Location = new System.Drawing.Point(3, 29);
            this.dgProfesores.MultiSelect = false;
            this.dgProfesores.Name = "dgProfesores";
            this.dgProfesores.ReadOnly = true;
            this.dgProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesores.Size = new System.Drawing.Size(417, 418);
            this.dgProfesores.TabIndex = 0;
            this.dgProfesores.DoubleClick += new System.EventHandler(this.dgPersonas_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgProfesores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreApellido, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreApellido.Location = new System.Drawing.Point(101, 3);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(319, 20);
            this.txtNombreApellido.TabIndex = 2;
            this.txtNombreApellido.TextChanged += new System.EventHandler(this.txtNombreApellido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre / Apellido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ProfesorNombre.DataPropertyName = "ProfesorNombre";
            this.ProfesorNombre.HeaderText = "Nombre";
            this.ProfesorNombre.Name = "ProfesorNombre";
            this.ProfesorNombre.ReadOnly = true;
            // 
            // ProfesorApellido
            // 
            this.ProfesorApellido.DataPropertyName = "ProfesorApellido";
            this.ProfesorApellido.HeaderText = "Apellido";
            this.ProfesorApellido.Name = "ProfesorApellido";
            this.ProfesorApellido.ReadOnly = true;
            // 
            // ProfesorLegajo
            // 
            this.ProfesorLegajo.DataPropertyName = "ProfesorLegajo";
            this.ProfesorLegajo.HeaderText = "Legajo";
            this.ProfesorLegajo.Name = "ProfesorLegajo";
            this.ProfesorLegajo.ReadOnly = true;
            // 
            // ProfesoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfesoresList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesores)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProfesores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorLegajo;
    }
}