
namespace Aplicacion_RRHH
{
    partial class Form7
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JORNADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROYECTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IN_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(427, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Subir";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(358, 36);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(261, 22);
            this.txtFile.TabIndex = 1;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUT,
            this.DV,
            this.NOMBRES,
            this.AP_PATERNO,
            this.AP_MATERNO,
            this.JORNADA,
            this.PROYECTO,
            this.CARGO,
            this.IN_CONTRATO,
            this.TIPO_CONTRATO,
            this.DURACION,
            this.SUELDO});
            this.dgItems.Location = new System.Drawing.Point(12, 79);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1180, 372);
            this.dgItems.TabIndex = 2;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RUT
            // 
            this.RUT.HeaderText = "RUT";
            this.RUT.MinimumWidth = 6;
            this.RUT.Name = "RUT";
            this.RUT.Width = 125;
            // 
            // DV
            // 
            this.DV.HeaderText = "DV";
            this.DV.MinimumWidth = 6;
            this.DV.Name = "DV";
            this.DV.Width = 125;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 125;
            // 
            // AP_PATERNO
            // 
            this.AP_PATERNO.HeaderText = "APELLIDO PATERNO";
            this.AP_PATERNO.MinimumWidth = 6;
            this.AP_PATERNO.Name = "AP_PATERNO";
            this.AP_PATERNO.Width = 125;
            // 
            // AP_MATERNO
            // 
            this.AP_MATERNO.HeaderText = "APELLIDO MATERNO";
            this.AP_MATERNO.MinimumWidth = 6;
            this.AP_MATERNO.Name = "AP_MATERNO";
            this.AP_MATERNO.Width = 125;
            // 
            // JORNADA
            // 
            this.JORNADA.HeaderText = "JORNADA";
            this.JORNADA.MinimumWidth = 6;
            this.JORNADA.Name = "JORNADA";
            this.JORNADA.Width = 125;
            // 
            // PROYECTO
            // 
            this.PROYECTO.HeaderText = "PROYECTO";
            this.PROYECTO.MinimumWidth = 6;
            this.PROYECTO.Name = "PROYECTO";
            this.PROYECTO.Width = 125;
            // 
            // CARGO
            // 
            this.CARGO.HeaderText = "CARGO";
            this.CARGO.MinimumWidth = 6;
            this.CARGO.Name = "CARGO";
            this.CARGO.Width = 125;
            // 
            // IN_CONTRATO
            // 
            this.IN_CONTRATO.HeaderText = "INICIO CONTRATO";
            this.IN_CONTRATO.MinimumWidth = 6;
            this.IN_CONTRATO.Name = "IN_CONTRATO";
            this.IN_CONTRATO.Width = 125;
            // 
            // TIPO_CONTRATO
            // 
            this.TIPO_CONTRATO.HeaderText = "TIPO CONTRATO";
            this.TIPO_CONTRATO.MinimumWidth = 6;
            this.TIPO_CONTRATO.Name = "TIPO_CONTRATO";
            this.TIPO_CONTRATO.Width = 125;
            // 
            // DURACION
            // 
            this.DURACION.HeaderText = "DURACIÓN";
            this.DURACION.MinimumWidth = 6;
            this.DURACION.Name = "DURACION";
            this.DURACION.Width = 125;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 6;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seleccionar Archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 549);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSave);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn JORNADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROYECTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IN_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
    }
}