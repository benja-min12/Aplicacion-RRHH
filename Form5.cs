using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    public partial class Form5 : Form
    {
        public int id;
        public Employee employee;
        public Form5(int id)
        {
            InitializeComponent();
            this.id = id;
            MySqlConnection connection = Program.conectionDb();
            connection.Open();

            // DbConnection that is already opened
            using (Db context = new Db(connection, false))
            {
                this.employee = context.employees.First<Employee>(e => e.id == id);
                connection.Close();
            }
            
            


        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmBoxProf.Items.Add("Profesional");
            cmBoxProf.Items.Add("Técnico");
            cmBoxProf.Items.Add("Sin título");
            textRut.Text = employee.rut + "-" + employee.dv;
            textNombre.Text = employee.name;
            textApellidoP.Text = employee.lastnameP;
            textApellidoM.Text = employee.lastnameM;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.Show();
            this.Hide();
        }

        private void cmBoxProf_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmBoxProf.Text = cmBoxProf.SelectedItem.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void txtBoxNat_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string nationality = txtBoxNat.Text;
            string email =txtBoxEmail.Text;
            string address= txtBoxAdd.Text;
            string title = cmBoxProf.Text;
            string dateTime= dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string phone = txtBoxPhone.Text;
            string query = "UPDATE `rrhh`.`employees` SET `nationality` = '"+nationality+"', `email` = '"+email+"', `address` = '"+address+"', `title` = '"+title+"', `dateBirth` = '"+dateTime+"', `phone` = '"+phone+"' WHERE (`id` = '"+id+"');";
            MySqlConnection connection = Program.conectionDb();
            connection.Open();
            using (Db context = new Db(connection, false))
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand(query);
                if (noOfRowUpdated > 0)
                {
                    MessageBox.Show("Empleado modificado");
                    
                }
                else
                {
                    MessageBox.Show("Error al modificar empleado");
                }
                
            }
            connection.Close();
           






        }

        
    }
}
