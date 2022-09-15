using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MySqlConnection connection = Program.conectionDb();
            connection.Open();

            // DbConnection that is already opened
            using (var context = new Db(connection, false))
            {
                List<Employee> employees = context.employees.ToList<Employee>();

                foreach (Employee employee in employees)
                {
                    dataGridView1.Rows.Add(employee.rut+"-"+employee.dv, employee.name, employee.lastnameM + " " + employee.lastnameP, employee.nationality, employee.email, employee.address, employee.title, employee.phone, employee.id);
                }



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBac_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
       
        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            Form5 obj5 = new Form5(id);
            obj5.Show();
            this.Hide();
        }
    }
}
