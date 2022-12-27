namespace FarmaSoft
{
    partial class frmPrincipal
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
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.Panel2.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.cantidadRestante});
            this.dgvRecursos.Location = new System.Drawing.Point(4, 20);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.Size = new System.Drawing.Size(926, 475);
            this.dgvRecursos.TabIndex = 0;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // cantidadRestante
            // 
            this.cantidadRestante.HeaderText = "Cantidad Restante";
            this.cantidadRestante.Name = "cantidadRestante";
            this.cantidadRestante.Width = 150;
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Location = new System.Drawing.Point(12, 24);
            this.spcPrincipal.Name = "spcPrincipal";
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.Controls.Add(this.btnReportes);
            this.spcPrincipal.Panel1.Controls.Add(this.btnMovimientos);
            this.spcPrincipal.Panel1.Controls.Add(this.btnGeneral);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.Controls.Add(this.dgvRecursos);
            this.spcPrincipal.Size = new System.Drawing.Size(1085, 511);
            this.spcPrincipal.SplitterDistance = 125;
            this.spcPrincipal.TabIndex = 1;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(3, 130);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(119, 30);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Location = new System.Drawing.Point(3, 81);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(119, 30);
            this.btnMovimientos.TabIndex = 1;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(3, 34);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(119, 30);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 547);
            this.Controls.Add(this.spcPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "FarmaSoft";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadRestante;
        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnMovimientos;
    }
}

