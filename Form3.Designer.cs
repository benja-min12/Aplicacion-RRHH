namespace Aplicacion_RRHH
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(75, 70);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 548);
            this.listBox1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(75, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Listado de Trabajadores";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModify.Location = new System.Drawing.Point(707, 453);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(141, 64);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modificar datos";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Location = new System.Drawing.Point(897, 555);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 64);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBac
            // 
            this.btnBac.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBac.Location = new System.Drawing.Point(707, 555);
            this.btnBac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBac.Name = "btnBac";
            this.btnBac.Size = new System.Drawing.Size(141, 64);
            this.btnBac.TabIndex = 55;
            this.btnBac.Text = "Volver";
            this.btnBac.UseVisualStyleBackColor = false;
            this.btnBac.Click += new System.EventHandler(this.btnBac_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.btnBac);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Lista de Contratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBac;
    }
}