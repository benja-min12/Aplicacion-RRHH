﻿namespace Aplicacion_RRHH
{
    partial class Form2
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
            this.lblNroContract = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblWorkDay = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.txtBoxRut = new System.Windows.Forms.TextBox();
            this.txtBoxDV = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAP = new System.Windows.Forms.TextBox();
            this.txtBoxAM = new System.Windows.Forms.TextBox();
            this.txtBoxJob = new System.Windows.Forms.TextBox();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.txtBoxProj = new System.Windows.Forms.TextBox();
            this.chkBoxIndef = new System.Windows.Forms.CheckBox();
            this.chkBoxTemp = new System.Windows.Forms.CheckBox();
            this.chkBoxComp = new System.Windows.Forms.CheckBox();
            this.chkBoxMedia = new System.Windows.Forms.CheckBox();
            this.dTPickerStart = new System.Windows.Forms.DateTimePicker();
            this.dTPickerFinish = new System.Windows.Forms.DateTimePicker();
            this.chkBoxYes = new System.Windows.Forms.CheckBox();
            this.chkBoxNo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDV = new System.Windows.Forms.Label();
            this.cmBoxDV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNroContract
            // 
            this.lblNroContract.AutoSize = true;
            this.lblNroContract.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroContract.Location = new System.Drawing.Point(30, 60);
            this.lblNroContract.Name = "lblNroContract";
            this.lblNroContract.Size = new System.Drawing.Size(76, 13);
            this.lblNroContract.TabIndex = 0;
            this.lblNroContract.Text = "ID de Contrato";
            this.lblNroContract.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.BackColor = System.Drawing.SystemColors.Control;
            this.lblRut.Location = new System.Drawing.Point(30, 99);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "Rut";
            this.lblRut.Click += new System.EventHandler(this.lblDV_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(30, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombres";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.BackColor = System.Drawing.SystemColors.Control;
            this.lblAP.Location = new System.Drawing.Point(30, 211);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(83, 13);
            this.lblAP.TabIndex = 3;
            this.lblAP.Text = "Apellido paterno";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.BackColor = System.Drawing.SystemColors.Control;
            this.lblAM.Location = new System.Drawing.Point(30, 247);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(85, 13);
            this.lblAM.TabIndex = 4;
            this.lblAM.Text = "Apellido materno";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.SystemColors.Control;
            this.lblJob.Location = new System.Drawing.Point(28, 291);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(40, 13);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Puesto";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalary.Location = new System.Drawing.Point(31, 326);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(40, 13);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Sueldo";
            this.lblSalary.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.BackColor = System.Drawing.SystemColors.Control;
            this.lblProject.Location = new System.Drawing.Point(31, 362);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(85, 13);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "Código Proyecto";
            this.lblProject.Click += new System.EventHandler(this.lblProject_Click);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.BackColor = System.Drawing.SystemColors.Control;
            this.lblContract.Location = new System.Drawing.Point(28, 399);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(86, 13);
            this.lblContract.TabIndex = 8;
            this.lblContract.Text = "Tipo de Contrato";
            // 
            // lblWorkDay
            // 
            this.lblWorkDay.AutoSize = true;
            this.lblWorkDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblWorkDay.Location = new System.Drawing.Point(31, 466);
            this.lblWorkDay.Name = "lblWorkDay";
            this.lblWorkDay.Size = new System.Drawing.Size(45, 13);
            this.lblWorkDay.TabIndex = 9;
            this.lblWorkDay.Text = "Jornada";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblStartDate.Location = new System.Drawing.Point(31, 518);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(79, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Fecha de inicio";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblFinishDate.Location = new System.Drawing.Point(31, 560);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(89, 13);
            this.lblFinishDate.TabIndex = 11;
            this.lblFinishDate.Text = "Fecha de término";
            this.lblFinishDate.Click += new System.EventHandler(this.lblFinishDate_Click);
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidity.Location = new System.Drawing.Point(31, 600);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(48, 13);
            this.lblValidity.TabIndex = 12;
            this.lblValidity.Text = "Vigencia";
            // 
            // txtBoxRut
            // 
            this.txtBoxRut.Location = new System.Drawing.Point(201, 60);
            this.txtBoxRut.Name = "txtBoxRut";
            this.txtBoxRut.Size = new System.Drawing.Size(186, 20);
            this.txtBoxRut.TabIndex = 13;
            // 
            // txtBoxDV
            // 
            this.txtBoxDV.Location = new System.Drawing.Point(201, 99);
            this.txtBoxDV.Name = "txtBoxDV";
            this.txtBoxDV.Size = new System.Drawing.Size(186, 20);
            this.txtBoxDV.TabIndex = 14;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(201, 170);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(186, 20);
            this.txtBoxName.TabIndex = 15;
            // 
            // txtBoxAP
            // 
            this.txtBoxAP.Location = new System.Drawing.Point(201, 203);
            this.txtBoxAP.Name = "txtBoxAP";
            this.txtBoxAP.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAP.TabIndex = 16;
            // 
            // txtBoxAM
            // 
            this.txtBoxAM.Location = new System.Drawing.Point(201, 247);
            this.txtBoxAM.Name = "txtBoxAM";
            this.txtBoxAM.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAM.TabIndex = 17;
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Location = new System.Drawing.Point(201, 290);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(186, 20);
            this.txtBoxJob.TabIndex = 18;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(201, 325);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(186, 20);
            this.txtBoxSalary.TabIndex = 19;
            // 
            // txtBoxProj
            // 
            this.txtBoxProj.Location = new System.Drawing.Point(201, 361);
            this.txtBoxProj.Name = "txtBoxProj";
            this.txtBoxProj.Size = new System.Drawing.Size(186, 20);
            this.txtBoxProj.TabIndex = 20;
            // 
            // chkBoxIndef
            // 
            this.chkBoxIndef.AutoSize = true;
            this.chkBoxIndef.Location = new System.Drawing.Point(201, 398);
            this.chkBoxIndef.Name = "chkBoxIndef";
            this.chkBoxIndef.Size = new System.Drawing.Size(88, 17);
            this.chkBoxIndef.TabIndex = 21;
            this.chkBoxIndef.Text = "INDEFINIDO";
            this.chkBoxIndef.UseVisualStyleBackColor = true;
            // 
            // chkBoxTemp
            // 
            this.chkBoxTemp.AutoSize = true;
            this.chkBoxTemp.Location = new System.Drawing.Point(201, 422);
            this.chkBoxTemp.Name = "chkBoxTemp";
            this.chkBoxTemp.Size = new System.Drawing.Size(85, 17);
            this.chkBoxTemp.TabIndex = 22;
            this.chkBoxTemp.Text = "TEMPORAL";
            this.chkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // chkBoxComp
            // 
            this.chkBoxComp.AutoSize = true;
            this.chkBoxComp.Location = new System.Drawing.Point(201, 460);
            this.chkBoxComp.Name = "chkBoxComp";
            this.chkBoxComp.Size = new System.Drawing.Size(84, 17);
            this.chkBoxComp.TabIndex = 23;
            this.chkBoxComp.Text = "COMPLETA";
            this.chkBoxComp.UseVisualStyleBackColor = true;
            // 
            // chkBoxMedia
            // 
            this.chkBoxMedia.AutoSize = true;
            this.chkBoxMedia.Location = new System.Drawing.Point(201, 484);
            this.chkBoxMedia.Name = "chkBoxMedia";
            this.chkBoxMedia.Size = new System.Drawing.Size(114, 17);
            this.chkBoxMedia.TabIndex = 24;
            this.chkBoxMedia.Text = "MEDIA JORNADA";
            this.chkBoxMedia.UseVisualStyleBackColor = true;
            // 
            // dTPickerStart
            // 
            this.dTPickerStart.Location = new System.Drawing.Point(201, 517);
            this.dTPickerStart.Name = "dTPickerStart";
            this.dTPickerStart.Size = new System.Drawing.Size(200, 20);
            this.dTPickerStart.TabIndex = 25;
            // 
            // dTPickerFinish
            // 
            this.dTPickerFinish.Location = new System.Drawing.Point(201, 559);
            this.dTPickerFinish.Name = "dTPickerFinish";
            this.dTPickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dTPickerFinish.TabIndex = 26;
            // 
            // chkBoxYes
            // 
            this.chkBoxYes.AutoSize = true;
            this.chkBoxYes.Location = new System.Drawing.Point(201, 599);
            this.chkBoxYes.Name = "chkBoxYes";
            this.chkBoxYes.Size = new System.Drawing.Size(36, 17);
            this.chkBoxYes.TabIndex = 27;
            this.chkBoxYes.Text = "SI";
            this.chkBoxYes.UseVisualStyleBackColor = true;
            // 
            // chkBoxNo
            // 
            this.chkBoxNo.AutoSize = true;
            this.chkBoxNo.Location = new System.Drawing.Point(321, 598);
            this.chkBoxNo.Name = "chkBoxNo";
            this.chkBoxNo.Size = new System.Drawing.Size(42, 17);
            this.chkBoxNo.TabIndex = 28;
            this.chkBoxNo.Text = "NO";
            this.chkBoxNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ingreso de Contrataciones";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerate.Location = new System.Drawing.Point(466, 525);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 49);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generar contrato";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Location = new System.Drawing.Point(466, 595);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 49);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.BackColor = System.Drawing.SystemColors.Control;
            this.lblDV.Location = new System.Drawing.Point(30, 134);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(22, 13);
            this.lblDV.TabIndex = 45;
            this.lblDV.Text = "DV";
            // 
            // cmBoxDV
            // 
            this.cmBoxDV.FormattingEnabled = true;
            this.cmBoxDV.Location = new System.Drawing.Point(201, 134);
            this.cmBoxDV.Name = "cmBoxDV";
            this.cmBoxDV.Size = new System.Drawing.Size(186, 21);
            this.cmBoxDV.TabIndex = 46;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 701);
            this.Controls.Add(this.cmBoxDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxNo);
            this.Controls.Add(this.chkBoxYes);
            this.Controls.Add(this.dTPickerFinish);
            this.Controls.Add(this.dTPickerStart);
            this.Controls.Add(this.chkBoxMedia);
            this.Controls.Add(this.chkBoxComp);
            this.Controls.Add(this.chkBoxTemp);
            this.Controls.Add(this.chkBoxIndef);
            this.Controls.Add(this.txtBoxProj);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.txtBoxJob);
            this.Controls.Add(this.txtBoxAM);
            this.Controls.Add(this.txtBoxAP);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxDV);
            this.Controls.Add(this.txtBoxRut);
            this.Controls.Add(this.lblValidity);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblWorkDay);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblAM);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblNroContract);
            this.Name = "Form2";
            this.Text = " Contratos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroContract;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblWorkDay;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.TextBox txtBoxRut;
        private System.Windows.Forms.TextBox txtBoxDV;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAP;
        private System.Windows.Forms.TextBox txtBoxAM;
        private System.Windows.Forms.TextBox txtBoxJob;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.TextBox txtBoxProj;
        private System.Windows.Forms.CheckBox chkBoxIndef;
        private System.Windows.Forms.CheckBox chkBoxTemp;
        private System.Windows.Forms.CheckBox chkBoxComp;
        private System.Windows.Forms.CheckBox chkBoxMedia;
        private System.Windows.Forms.DateTimePicker dTPickerStart;
        private System.Windows.Forms.DateTimePicker dTPickerFinish;
        private System.Windows.Forms.CheckBox chkBoxYes;
        private System.Windows.Forms.CheckBox chkBoxNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.ComboBox cmBoxDV;
    }
}