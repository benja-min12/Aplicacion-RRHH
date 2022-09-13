namespace Aplicacion_RRHH
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
            this.txtBoxDV = new System.Windows.Forms.TextBox();
            this.txtBoxRut = new System.Windows.Forms.TextBox();
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
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroContract
            // 
            this.lblNroContract.AutoSize = true;
            this.lblNroContract.BackColor = System.Drawing.SystemColors.Control;
            this.lblNroContract.Location = new System.Drawing.Point(45, 92);
            this.lblNroContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroContract.Name = "lblNroContract";
            this.lblNroContract.Size = new System.Drawing.Size(114, 20);
            this.lblNroContract.TabIndex = 0;
            this.lblNroContract.Text = "ID de Contrato";
            this.lblNroContract.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.BackColor = System.Drawing.SystemColors.Control;
            this.lblRut.Location = new System.Drawing.Point(45, 152);
            this.lblRut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(35, 20);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "Rut";
            this.lblRut.Click += new System.EventHandler(this.lblDV_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(45, 274);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombres";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.BackColor = System.Drawing.SystemColors.Control;
            this.lblAP.Location = new System.Drawing.Point(45, 325);
            this.lblAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(124, 20);
            this.lblAP.TabIndex = 3;
            this.lblAP.Text = "Apellido paterno";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.BackColor = System.Drawing.SystemColors.Control;
            this.lblAM.Location = new System.Drawing.Point(45, 380);
            this.lblAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(128, 20);
            this.lblAM.TabIndex = 4;
            this.lblAM.Text = "Apellido materno";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.SystemColors.Control;
            this.lblJob.Location = new System.Drawing.Point(42, 448);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(59, 20);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Puesto";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalary.Location = new System.Drawing.Point(46, 501);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 20);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Sueldo";
            this.lblSalary.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.BackColor = System.Drawing.SystemColors.Control;
            this.lblProject.Location = new System.Drawing.Point(46, 558);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(125, 20);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "Código Proyecto";
            this.lblProject.Click += new System.EventHandler(this.lblProject_Click);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.BackColor = System.Drawing.SystemColors.Control;
            this.lblContract.Location = new System.Drawing.Point(42, 614);
            this.lblContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(127, 20);
            this.lblContract.TabIndex = 8;
            this.lblContract.Text = "Tipo de Contrato";
            // 
            // lblWorkDay
            // 
            this.lblWorkDay.AutoSize = true;
            this.lblWorkDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblWorkDay.Location = new System.Drawing.Point(46, 718);
            this.lblWorkDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkDay.Name = "lblWorkDay";
            this.lblWorkDay.Size = new System.Drawing.Size(67, 20);
            this.lblWorkDay.TabIndex = 9;
            this.lblWorkDay.Text = "Jornada";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblStartDate.Location = new System.Drawing.Point(46, 798);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(115, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Fecha de inicio";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblFinishDate.Location = new System.Drawing.Point(46, 861);
            this.lblFinishDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(133, 20);
            this.lblFinishDate.TabIndex = 11;
            this.lblFinishDate.Text = "Fecha de término";
            this.lblFinishDate.Click += new System.EventHandler(this.lblFinishDate_Click);
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidity.Location = new System.Drawing.Point(46, 922);
            this.lblValidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(70, 20);
            this.lblValidity.TabIndex = 12;
            this.lblValidity.Text = "Vigencia";
            // 
            // txtBoxDV
            // 
            this.txtBoxDV.Location = new System.Drawing.Point(302, 92);
            this.txtBoxDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDV.Name = "txtBoxDV";
            this.txtBoxDV.Size = new System.Drawing.Size(277, 26);
            this.txtBoxDV.TabIndex = 13;
            this.txtBoxDV.TextChanged += new System.EventHandler(this.txtBoxRut_TextChanged);
            // 
            // txtBoxRut
            // 
            this.txtBoxRut.Location = new System.Drawing.Point(302, 152);
            this.txtBoxRut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxRut.MaxLength = 8;
            this.txtBoxRut.Name = "txtBoxRut";
            this.txtBoxRut.Size = new System.Drawing.Size(277, 26);
            this.txtBoxRut.TabIndex = 14;
            this.txtBoxRut.TextChanged += new System.EventHandler(this.txtBoxRut_TextChanged_1);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(302, 261);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(277, 26);
            this.txtBoxName.TabIndex = 15;
            // 
            // txtBoxAP
            // 
            this.txtBoxAP.Location = new System.Drawing.Point(302, 312);
            this.txtBoxAP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAP.Name = "txtBoxAP";
            this.txtBoxAP.Size = new System.Drawing.Size(277, 26);
            this.txtBoxAP.TabIndex = 16;
            // 
            // txtBoxAM
            // 
            this.txtBoxAM.Location = new System.Drawing.Point(302, 380);
            this.txtBoxAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAM.Name = "txtBoxAM";
            this.txtBoxAM.Size = new System.Drawing.Size(277, 26);
            this.txtBoxAM.TabIndex = 17;
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Location = new System.Drawing.Point(302, 446);
            this.txtBoxJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(277, 26);
            this.txtBoxJob.TabIndex = 18;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(302, 500);
            this.txtBoxSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(277, 26);
            this.txtBoxSalary.TabIndex = 19;
            // 
            // txtBoxProj
            // 
            this.txtBoxProj.Location = new System.Drawing.Point(302, 555);
            this.txtBoxProj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxProj.Name = "txtBoxProj";
            this.txtBoxProj.Size = new System.Drawing.Size(277, 26);
            this.txtBoxProj.TabIndex = 20;
            // 
            // chkBoxIndef
            // 
            this.chkBoxIndef.AutoSize = true;
            this.chkBoxIndef.Location = new System.Drawing.Point(302, 612);
            this.chkBoxIndef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxIndef.Name = "chkBoxIndef";
            this.chkBoxIndef.Size = new System.Drawing.Size(129, 24);
            this.chkBoxIndef.TabIndex = 21;
            this.chkBoxIndef.Text = "INDEFINIDO";
            this.chkBoxIndef.UseVisualStyleBackColor = true;
            // 
            // chkBoxTemp
            // 
            this.chkBoxTemp.AutoSize = true;
            this.chkBoxTemp.Location = new System.Drawing.Point(302, 649);
            this.chkBoxTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxTemp.Name = "chkBoxTemp";
            this.chkBoxTemp.Size = new System.Drawing.Size(122, 24);
            this.chkBoxTemp.TabIndex = 22;
            this.chkBoxTemp.Text = "TEMPORAL";
            this.chkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // chkBoxComp
            // 
            this.chkBoxComp.AutoSize = true;
            this.chkBoxComp.Location = new System.Drawing.Point(302, 708);
            this.chkBoxComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxComp.Name = "chkBoxComp";
            this.chkBoxComp.Size = new System.Drawing.Size(121, 24);
            this.chkBoxComp.TabIndex = 23;
            this.chkBoxComp.Text = "COMPLETA";
            this.chkBoxComp.UseVisualStyleBackColor = true;
            // 
            // chkBoxMedia
            // 
            this.chkBoxMedia.AutoSize = true;
            this.chkBoxMedia.Location = new System.Drawing.Point(302, 745);
            this.chkBoxMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxMedia.Name = "chkBoxMedia";
            this.chkBoxMedia.Size = new System.Drawing.Size(168, 24);
            this.chkBoxMedia.TabIndex = 24;
            this.chkBoxMedia.Text = "MEDIA JORNADA";
            this.chkBoxMedia.UseVisualStyleBackColor = true;
            // 
            // dTPickerStart
            // 
            this.dTPickerStart.Location = new System.Drawing.Point(302, 795);
            this.dTPickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTPickerStart.Name = "dTPickerStart";
            this.dTPickerStart.Size = new System.Drawing.Size(298, 26);
            this.dTPickerStart.TabIndex = 25;
            this.dTPickerStart.ValueChanged += new System.EventHandler(this.dTPickerStart_ValueChanged);
            // 
            // dTPickerFinish
            // 
            this.dTPickerFinish.Location = new System.Drawing.Point(302, 860);
            this.dTPickerFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTPickerFinish.Name = "dTPickerFinish";
            this.dTPickerFinish.Size = new System.Drawing.Size(298, 26);
            this.dTPickerFinish.TabIndex = 26;
            // 
            // chkBoxYes
            // 
            this.chkBoxYes.AutoSize = true;
            this.chkBoxYes.Location = new System.Drawing.Point(302, 921);
            this.chkBoxYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxYes.Name = "chkBoxYes";
            this.chkBoxYes.Size = new System.Drawing.Size(51, 24);
            this.chkBoxYes.TabIndex = 27;
            this.chkBoxYes.Text = "SI";
            this.chkBoxYes.UseVisualStyleBackColor = true;
            // 
            // chkBoxNo
            // 
            this.chkBoxNo.AutoSize = true;
            this.chkBoxNo.Location = new System.Drawing.Point(482, 920);
            this.chkBoxNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxNo.Name = "chkBoxNo";
            this.chkBoxNo.Size = new System.Drawing.Size(58, 24);
            this.chkBoxNo.TabIndex = 28;
            this.chkBoxNo.Text = "NO";
            this.chkBoxNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ingreso de Contrataciones";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerate.Location = new System.Drawing.Point(699, 808);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 75);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generar contrato";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Location = new System.Drawing.Point(699, 915);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 75);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.BackColor = System.Drawing.SystemColors.Control;
            this.lblDV.Location = new System.Drawing.Point(45, 206);
            this.lblDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(32, 20);
            this.lblDV.TabIndex = 45;
            this.lblDV.Text = "DV";
            // 
            // cmBoxDV
            // 
            this.cmBoxDV.FormattingEnabled = true;
            this.cmBoxDV.Location = new System.Drawing.Point(302, 206);
            this.cmBoxDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmBoxDV.Name = "cmBoxDV";
            this.cmBoxDV.Size = new System.Drawing.Size(277, 28);
            this.cmBoxDV.TabIndex = 46;
            this.cmBoxDV.SelectedIndexChanged += new System.EventHandler(this.cmBoxDV_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.SystemColors.Control;
            this.lblTest.Location = new System.Drawing.Point(695, 261);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(49, 20);
            this.lblTest.TabIndex = 47;
            this.lblTest.Text = "TEST";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 1050);
            this.Controls.Add(this.lblTest);
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
            this.Controls.Add(this.txtBoxRut);
            this.Controls.Add(this.txtBoxDV);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox txtBoxDV;
        private System.Windows.Forms.TextBox txtBoxRut;
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
        private System.Windows.Forms.Label lblTest;
    }
}