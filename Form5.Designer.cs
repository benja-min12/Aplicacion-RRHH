﻿namespace Aplicacion_RRHH
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRut = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmBoxProf = new System.Windows.Forms.ComboBox();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxNat = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Registro de Trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Apellido paterno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(27, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Apellido materno";
            // 
            // textRut
            // 
            this.textRut.Location = new System.Drawing.Point(198, 83);
            this.textRut.Name = "textRut";
            this.textRut.ReadOnly = true;
            this.textRut.Size = new System.Drawing.Size(186, 20);
            this.textRut.TabIndex = 38;
            this.textRut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(198, 119);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(186, 20);
            this.textNombre.TabIndex = 39;
            // 
            // textApellidoP
            // 
            this.textApellidoP.Location = new System.Drawing.Point(198, 152);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.ReadOnly = true;
            this.textApellidoP.Size = new System.Drawing.Size(186, 20);
            this.textApellidoP.TabIndex = 40;
            // 
            // textApellidoM
            // 
            this.textApellidoM.Location = new System.Drawing.Point(198, 190);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.ReadOnly = true;
            this.textApellidoM.Size = new System.Drawing.Size(186, 20);
            this.textApellidoM.TabIndex = 41;
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(27, 230);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(69, 13);
            this.lblNation.TabIndex = 45;
            this.lblNation.Text = "Nacionalidad";
            this.lblNation.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(27, 263);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(108, 13);
            this.lblBorn.TabIndex = 46;
            this.lblBorn.Text = "Fecha de Nacimiento";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(27, 301);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(35, 13);
            this.lblProf.TabIndex = 47;
            this.lblProf.Text = "Título";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(27, 352);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(52, 13);
            this.lblAddr.TabIndex = 48;
            this.lblAddr.Text = "Dirección";
            this.lblAddr.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 393);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 13);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 430);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 50;
            this.lblPhone.Text = "Teléfono";
            // 
            // cmBoxProf
            // 
            this.cmBoxProf.FormattingEnabled = true;
            this.cmBoxProf.Location = new System.Drawing.Point(198, 301);
            this.cmBoxProf.Name = "cmBoxProf";
            this.cmBoxProf.Size = new System.Drawing.Size(186, 21);
            this.cmBoxProf.TabIndex = 51;
            this.cmBoxProf.SelectedIndexChanged += new System.EventHandler(this.cmBoxProf_SelectedIndexChanged);
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(198, 352);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAdd.TabIndex = 52;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(198, 393);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(186, 20);
            this.txtBoxEmail.TabIndex = 53;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(198, 430);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(186, 20);
            this.txtBoxPhone.TabIndex = 54;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModify.Location = new System.Drawing.Point(438, 352);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(106, 52);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modificar datos";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Location = new System.Drawing.Point(438, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxNat
            // 
            this.txtBoxNat.Location = new System.Drawing.Point(198, 226);
            this.txtBoxNat.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNat.Name = "txtBoxNat";
            this.txtBoxNat.Size = new System.Drawing.Size(186, 20);
            this.txtBoxNat.TabIndex = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 542);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxNat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxAdd);
            this.Controls.Add(this.cmBoxProf);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellidoM);
            this.Controls.Add(this.textApellidoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Form5";
            this.Text = "Ingreso de Trabajadores";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRut;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmBoxProf;
        private System.Windows.Forms.TextBox txtBoxAdd;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBoxNat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}