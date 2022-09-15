using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            MySqlConnection connection = Program.conectionDb();
            connection.Open();

            // DbConnection that is already opened
            using (var context = new Db(connection, false))
            {
                List<Contract> contracts = context.contracts.ToList<Contract>();

                foreach (Contract contract in contracts)
                {

                    dataGridView1.Rows.Add(contract.nContract, contract.rut, contract.nameEmployee, contract.job, contract.salary, contract.proyect, contract.typeContract, contract.workingDay);
                }



            }


        }
       

        private void btnBac_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
