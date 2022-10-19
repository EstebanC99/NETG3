
namespace Academia.UI.WindowsForms
{
    partial class ReporteCursosForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtMateriaDescrip = new System.Windows.Forms.TextBox();
            this.lbPlan = new System.Windows.Forms.Label();
            this.txtPlanDescrip = new System.Windows.Forms.TextBox();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDetalleCurso = new System.Windows.Forms.Label();
            this.dgAlumnosCurso = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartCondiciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAlumnos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtPlanDescrip, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPlan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMateriaDescrip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgCursos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDetalleCurso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgAlumnosCurso, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartCondiciones, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAlumnos, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMateria.Location = new System.Drawing.Point(3, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 26);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia:";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMateriaDescrip
            // 
            this.txtMateriaDescrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMateriaDescrip.Location = new System.Drawing.Point(54, 3);
            this.txtMateriaDescrip.Name = "txtMateriaDescrip";
            this.txtMateriaDescrip.Size = new System.Drawing.Size(300, 20);
            this.txtMateriaDescrip.TabIndex = 1;
            this.txtMateriaDescrip.TextChanged += new System.EventHandler(this.txtMateriaDescrip_TextChanged);
            // 
            // lbPlan
            // 
            this.lbPlan.AutoSize = true;
            this.lbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlan.Location = new System.Drawing.Point(360, 0);
            this.lbPlan.Name = "lbPlan";
            this.lbPlan.Size = new System.Drawing.Size(84, 26);
            this.lbPlan.TabIndex = 2;
            this.lbPlan.Text = "Plan:";
            this.lbPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlanDescrip
            // 
            this.txtPlanDescrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPlanDescrip.Location = new System.Drawing.Point(450, 3);
            this.txtPlanDescrip.Name = "txtPlanDescrip";
            this.txtPlanDescrip.Size = new System.Drawing.Size(271, 20);
            this.txtPlanDescrip.TabIndex = 3;
            this.txtPlanDescrip.TextChanged += new System.EventHandler(this.txtPlanDescrip_TextChanged);
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToAddRows = false;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MateriaDescripcion,
            this.AnioCalendario,
            this.ComisionDescripcion,
            this.PlanDescripcion,
            this.EspecialidadDescripcion});
            this.tableLayoutPanel1.SetColumnSpan(this.dgCursos, 4);
            this.dgCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCursos.Location = new System.Drawing.Point(3, 29);
            this.dgCursos.MultiSelect = false;
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCursos.Size = new System.Drawing.Size(718, 150);
            this.dgCursos.TabIndex = 4;
            this.dgCursos.SelectionChanged += new System.EventHandler(this.dgCursos_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MateriaDescripcion
            // 
            this.MateriaDescripcion.DataPropertyName = "MateriaDescripcion";
            this.MateriaDescripcion.HeaderText = "Materia";
            this.MateriaDescripcion.Name = "MateriaDescripcion";
            this.MateriaDescripcion.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // ComisionDescripcion
            // 
            this.ComisionDescripcion.DataPropertyName = "ComisionDescripcion";
            this.ComisionDescripcion.HeaderText = "Comision";
            this.ComisionDescripcion.Name = "ComisionDescripcion";
            this.ComisionDescripcion.ReadOnly = true;
            // 
            // PlanDescripcion
            // 
            this.PlanDescripcion.DataPropertyName = "PlanDescripcion";
            this.PlanDescripcion.HeaderText = "Plan";
            this.PlanDescripcion.Name = "PlanDescripcion";
            this.PlanDescripcion.ReadOnly = true;
            // 
            // EspecialidadDescripcion
            // 
            this.EspecialidadDescripcion.DataPropertyName = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.HeaderText = "Especialidad";
            this.EspecialidadDescripcion.Name = "EspecialidadDescripcion";
            this.EspecialidadDescripcion.ReadOnly = true;
            // 
            // lbDetalleCurso
            // 
            this.lbDetalleCurso.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDetalleCurso, 4);
            this.lbDetalleCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDetalleCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalleCurso.Location = new System.Drawing.Point(3, 182);
            this.lbDetalleCurso.Name = "lbDetalleCurso";
            this.lbDetalleCurso.Size = new System.Drawing.Size(718, 20);
            this.lbDetalleCurso.TabIndex = 5;
            this.lbDetalleCurso.Text = "Detalle del Curso";
            this.lbDetalleCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAlumnosCurso
            // 
            this.dgAlumnosCurso.AllowUserToAddRows = false;
            this.dgAlumnosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Apellido,
            this.Nombre,
            this.Condicion,
            this.Nota});
            this.tableLayoutPanel1.SetColumnSpan(this.dgAlumnosCurso, 4);
            this.dgAlumnosCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAlumnosCurso.Location = new System.Drawing.Point(3, 205);
            this.dgAlumnosCurso.MultiSelect = false;
            this.dgAlumnosCurso.Name = "dgAlumnosCurso";
            this.dgAlumnosCurso.ReadOnly = true;
            this.dgAlumnosCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlumnosCurso.Size = new System.Drawing.Size(718, 150);
            this.dgAlumnosCurso.TabIndex = 6;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "Nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // chartCondiciones
            // 
            this.chartCondiciones.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartCondiciones.ChartAreas.Add(chartArea2);
            this.chartCondiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartCondiciones.Legends.Add(legend2);
            this.chartCondiciones.Location = new System.Drawing.Point(54, 374);
            this.chartCondiciones.Name = "chartCondiciones";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Serie1";
            this.chartCondiciones.Series.Add(series2);
            this.chartCondiciones.Size = new System.Drawing.Size(300, 300);
            this.chartCondiciones.TabIndex = 7;
            this.chartCondiciones.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grafico de Condiciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alumnos totales:";
            // 
            // lblTotalAlumnos
            // 
            this.lblTotalAlumnos.AutoSize = true;
            this.lblTotalAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAlumnos.Location = new System.Drawing.Point(450, 371);
            this.lblTotalAlumnos.Name = "lblTotalAlumnos";
            this.lblTotalAlumnos.Size = new System.Drawing.Size(271, 13);
            this.lblTotalAlumnos.TabIndex = 10;
            // 
            // ReporteCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReporteCursosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCursosForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnosCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCondiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPlanDescrip;
        private System.Windows.Forms.Label lbPlan;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMateriaDescrip;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadDescripcion;
        private System.Windows.Forms.Label lbDetalleCurso;
        private System.Windows.Forms.DataGridView dgAlumnosCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCondiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAlumnos;
    }
}