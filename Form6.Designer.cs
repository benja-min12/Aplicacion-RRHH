﻿namespace Aplicacion_RRHH
{
    partial class Form6
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxRut = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAP = new System.Windows.Forms.TextBox();
            this.txtBoxAM = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.txtBoxDV = new System.Windows.Forms.TextBox();
            this.dTPickerFinish = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxCausal = new System.Windows.Forms.ComboBox();
            this.btnDesvinc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(33, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 29);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Ingreso de Desvinculación";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.BackColor = System.Drawing.SystemColors.Control;
            this.lblContract.Location = new System.Drawing.Point(34, 60);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(76, 13);
            this.lblContract.TabIndex = 32;
            this.lblContract.Text = "ID de Contrato";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.BackColor = System.Drawing.SystemColors.Control;
            this.lblRut.Location = new System.Drawing.Point(34, 99);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 33;
            this.lblRut.Text = "Rut";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(34, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Nombres";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.BackColor = System.Drawing.SystemColors.Control;
            this.lblAP.Location = new System.Drawing.Point(34, 214);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(83, 13);
            this.lblAP.TabIndex = 35;
            this.lblAP.Text = "Apellido paterno";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.BackColor = System.Drawing.SystemColors.Control;
            this.lblAM.Location = new System.Drawing.Point(34, 250);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(85, 13);
            this.lblAM.TabIndex = 36;
            this.lblAM.Text = "Apellido materno";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(205, 60);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(186, 20);
            this.txtBoxID.TabIndex = 37;
            // 
            // txtBoxRut
            // 
            this.txtBoxRut.Location = new System.Drawing.Point(205, 99);
            this.txtBoxRut.Name = "txtBoxRut";
            this.txtBoxRut.Size = new System.Drawing.Size(186, 20);
            this.txtBoxRut.TabIndex = 38;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(205, 173);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(186, 20);
            this.txtBoxName.TabIndex = 39;
            // 
            // txtBoxAP
            // 
            this.txtBoxAP.Location = new System.Drawing.Point(205, 206);
            this.txtBoxAP.Name = "txtBoxAP";
            this.txtBoxAP.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAP.TabIndex = 40;
            // 
            // txtBoxAM
            // 
            this.txtBoxAM.Location = new System.Drawing.Point(205, 250);
            this.txtBoxAM.Name = "txtBoxAM";
            this.txtBoxAM.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAM.TabIndex = 41;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.BackColor = System.Drawing.SystemColors.Control;
            this.lblDV.Location = new System.Drawing.Point(34, 136);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(22, 13);
            this.lblDV.TabIndex = 43;
            this.lblDV.Text = "DV";
            // 
            // txtBoxDV
            // 
            this.txtBoxDV.Location = new System.Drawing.Point(205, 136);
            this.txtBoxDV.Name = "txtBoxDV";
            this.txtBoxDV.Size = new System.Drawing.Size(186, 20);
            this.txtBoxDV.TabIndex = 44;
            // 
            // dTPickerFinish
            // 
            this.dTPickerFinish.Location = new System.Drawing.Point(205, 291);
            this.dTPickerFinish.Name = "dTPickerFinish";
            this.dTPickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dTPickerFinish.TabIndex = 33;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.SystemColors.Control;
            this.lblFinish.Location = new System.Drawing.Point(34, 291);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(126, 13);
            this.lblFinish.TabIndex = 32;
            this.lblFinish.Text = "Fecha de desvinculación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Causal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmBoxCausal
            // 
            this.cmBoxCausal.FormattingEnabled = true;
            this.cmBoxCausal.Location = new System.Drawing.Point(205, 334);
            this.cmBoxCausal.Name = "cmBoxCausal";
            this.cmBoxCausal.Size = new System.Drawing.Size(200, 21);
            this.cmBoxCausal.TabIndex = 46;
            // 
            // btnDesvinc
            // 
            this.btnDesvinc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDesvinc.Location = new System.Drawing.Point(449, 291);
            this.btnDesvinc.Name = "btnDesvinc";
            this.btnDesvinc.Size = new System.Drawing.Size(92, 49);
            this.btnDesvinc.TabIndex = 32;
            this.btnDesvinc.Text = "Aplicar cambios";
            this.btnDesvinc.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Location = new System.Drawing.Point(449, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 49);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmBoxCausal);
            this.Controls.Add(this.btnDesvinc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPickerFinish);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.txtBoxDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxAM);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.txtBoxAP);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxRut);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblAM);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxRut;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAP;
        private System.Windows.Forms.TextBox txtBoxAM;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.TextBox txtBoxDV;
        private System.Windows.Forms.DateTimePicker dTPickerFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxCausal;
        private System.Windows.Forms.Button btnDesvinc;
        private System.Windows.Forms.Button btnBack;
    }
}