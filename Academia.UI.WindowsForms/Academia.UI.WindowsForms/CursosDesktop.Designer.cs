﻿
namespace Academia.UI.WindowsForms
{
    partial class CursosDesktop
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
            this.comboComisiones = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.comboMaterias = new System.Windows.Forms.ComboBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.comboComisiones, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAnioCalendario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCupo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboMaterias, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMas, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMenos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 165);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // comboComisiones
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboComisiones, 3);
            this.comboComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboComisiones.FormattingEnabled = true;
            this.comboComisiones.Location = new System.Drawing.Point(110, 111);
            this.comboComisiones.Name = "comboComisiones";
            this.comboComisiones.Size = new System.Drawing.Size(308, 21);
            this.comboComisiones.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comision";
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnioCalendario.Enabled = false;
            this.txtAnioCalendario.Location = new System.Drawing.Point(188, 55);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(151, 20);
            this.txtAnioCalendario.TabIndex = 2;
            this.txtAnioCalendario.Text = "1";
            this.txtAnioCalendario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año Calendario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtCupo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCupo, 3);
            this.txtCupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCupo.Location = new System.Drawing.Point(110, 29);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(308, 20);
            this.txtCupo.TabIndex = 1;
            // 
            // comboMaterias
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboMaterias, 3);
            this.comboMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboMaterias.FormattingEnabled = true;
            this.comboMaterias.Location = new System.Drawing.Point(110, 84);
            this.comboMaterias.Name = "comboMaterias";
            this.comboMaterias.Size = new System.Drawing.Size(308, 21);
            this.comboMaterias.TabIndex = 4;
            // 
            // btnMas
            // 
            this.btnMas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMas.Location = new System.Drawing.Point(345, 55);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(73, 23);
            this.btnMas.TabIndex = 9;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenos.Location = new System.Drawing.Point(110, 55);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(70, 23);
            this.btnMenos.TabIndex = 10;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(188, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(110, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(70, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // CursosDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 165);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "CursosDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CursosDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox comboMaterias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.ComboBox comboComisiones;
        private System.Windows.Forms.Label label5;
    }
}