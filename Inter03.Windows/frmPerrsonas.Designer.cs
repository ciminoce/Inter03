
namespace Inter03.Windows
{
    partial class frmPerrsonas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClaseAbstracta = new System.Windows.Forms.Button();
            this.btnClaseConcreta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClaseAbstracta);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiarGrilla);
            this.splitContainer1.Panel1.Controls.Add(this.btnClaseConcreta);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 517);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnClaseAbstracta
            // 
            this.btnClaseAbstracta.Location = new System.Drawing.Point(36, 137);
            this.btnClaseAbstracta.Name = "btnClaseAbstracta";
            this.btnClaseAbstracta.Size = new System.Drawing.Size(155, 64);
            this.btnClaseAbstracta.TabIndex = 0;
            this.btnClaseAbstracta.Text = "Abrstracción";
            this.btnClaseAbstracta.UseVisualStyleBackColor = true;
            this.btnClaseAbstracta.Click += new System.EventHandler(this.btnClaseAbstracta_Click);
            // 
            // btnClaseConcreta
            // 
            this.btnClaseConcreta.Location = new System.Drawing.Point(36, 50);
            this.btnClaseConcreta.Name = "btnClaseConcreta";
            this.btnClaseConcreta.Size = new System.Drawing.Size(155, 64);
            this.btnClaseConcreta.TabIndex = 0;
            this.btnClaseConcreta.Text = "Clase Concreta";
            this.btnClaseConcreta.UseVisualStyleBackColor = true;
            this.btnClaseConcreta.Click += new System.EventHandler(this.btnClaseConcreta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colFechaNac});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colFechaNac
            // 
            this.colFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFechaNac.HeaderText = "Fec. Nto.";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(36, 424);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(155, 64);
            this.btnLimpiarGrilla.TabIndex = 0;
            this.btnLimpiarGrilla.Text = "Limpiar Grilla";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // frmPerrsonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPerrsonas";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClaseAbstracta;
        private System.Windows.Forms.Button btnClaseConcreta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.Button btnLimpiarGrilla;
    }
}

