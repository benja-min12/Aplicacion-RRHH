using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract = Aplicacion_RRHH.Model.Contract;

namespace Aplicacion_RRHH
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDV_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmBoxDV.Items.Add("0");
            cmBoxDV.Items.Add("1");
            cmBoxDV.Items.Add("2");
            cmBoxDV.Items.Add("3");
            cmBoxDV.Items.Add("4");
            cmBoxDV.Items.Add("5");
            cmBoxDV.Items.Add("6");
            cmBoxDV.Items.Add("7");
            cmBoxDV.Items.Add("8");
            cmBoxDV.Items.Add("9");
            cmBoxDV.Items.Add("k");
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String contract_type = "";
            String wk_day = "";
            String ans_yes = "";
            String ans_no = "";

            if (chkBoxIndef.Checked == true)
            {
                contract_type = "indefinido";
                //txtBoxName.Text = contract_type;
            }

            if (chkBoxTemp.Checked == true)
            {
                contract_type = "temporal";
                //txtBoxName.Text = contract_type;

            }

            if (chkBoxComp.Checked == true)
            {
                wk_day = "completa";
            }

            if (chkBoxMedia.Checked == true)
            {
                wk_day = "media";
            }

            DateTime start_date = dTPickerStart.Value;
            String startDate_string = start_date.ToString("dd/MM/yyyy");

            DateTime finish_date = dTPickerFinish.Value;
            String finishDate_string = finish_date.ToString("dd/MM/yyyy");

            if (chkBoxYes.Checked == true)
            {
                ans_yes = "yes";
            }


            if (chkBoxNo.Checked == true)
            {
                ans_no = "no";
            }
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void lblFinishDate_Click(object sender, EventArgs e)
        {

        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void txtBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRut_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dTPickerStart_ValueChanged(object sender, EventArgs e)
        {
            //DateTime date = dTPickerStart.Value;
            //lblTest.Text = date.ToString("dd/MM/yyyy");

        }
    }
}
