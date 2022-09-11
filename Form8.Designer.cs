
namespace Aplicacion_RRHH
{
    partial class Form8
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMCONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHDESVIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAUSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Seleccionar Archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.NUMCONT,
            this.FECHDESVIN,
            this.CAUSAL});
            this.dgItems.Location = new System.Drawing.Point(27, 75);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1049, 372);
            this.dgItems.TabIndex = 7;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(357, 26);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(261, 22);
            this.txtFile.TabIndex = 6;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(426, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Subir";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // NUMCONT
            // 
            this.NUMCONT.HeaderText = "NÚMERO CONTRATO";
            this.NUMCONT.MinimumWidth = 6;
            this.NUMCONT.Name = "NUMCONT";
            this.NUMCONT.Width = 125;
            // 
            // FECHDESVIN
            // 
            this.FECHDESVIN.HeaderText = "FECHA DESVINCULACIÓN";
            this.FECHDESVIN.MinimumWidth = 6;
            this.FECHDESVIN.Name = "FECHDESVIN";
            this.FECHDESVIN.Width = 125;
            // 
            // CAUSAL
            // 
            this.CAUSAL.HeaderText = "CAUSAL";
            this.CAUSAL.MinimumWidth = 6;
            this.CAUSAL.Name = "CAUSAL";
            this.CAUSAL.Width = 125;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSave);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMCONT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHDESVIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAUSAL;
    }
}