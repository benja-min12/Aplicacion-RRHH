using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV file|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dgItems.DataSource = ReadCsvFile(ofd.FileName);

                }
            }
        }

        public DataTable ReadCsvFile(string file)
        {
            DataTable dt = new DataTable();
            using (StreamReader streamReader = new StreamReader(file))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadToEnd();
                    string[] rows = text.Split('\n');
                    if (rows.Length > 0)
                    {
                        //Add columns
                        string[] columns = rows[0].Split(';');
                        for (int j = 0; j < columns.Count(); j++)
                            dt.Columns.Add(columns[j]);
                        //Add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(';');
                            DataRow dr = dt.NewRow();
                            for (int k = 0; k < data.Count(); k++)
                                dr[k] = data[k];
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.conectionDb();
            connection.Open();
            List<Contract> contracts = new List<Contract>();
            using (Db context = new Db(connection, false))
            {
                foreach (DataGridViewRow row in dgItems.Rows)
                {
                   
                    Contract contract = new Contract();
                    if (row.Cells[5].Value != null)
                    {
                        string nContractStr = row.Cells[5].Value.ToString();
                        int nContract = 0;


                        try
                        {
                            nContract = Convert.ToInt32(nContractStr);

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid String");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("The string cannot fit in 32 bit value");
                        }
                        contract = context.contracts.FirstOrDefault(c => c.nContract == nContract);
                        if (contract != null)
                        {
                            if (contract.rut == row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString())
                            {
                                contract.isValid = false;
                                try
                                {
                                    contract.dateFinish = Convert.ToDateTime(row.Cells[6].Value.ToString());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid String");
                                }
                                contract.reason = row.Cells[7].Value.ToString();
                                string query = "UPDATE `rrhh`.`contracts` SET `isValid` = '0', `reason` = '" + contract.reason + "', `dateFinish` = '" + contract.dateFinish.ToString("yyyy-MM-dd") + "' WHERE (`Id` = '" + contract.Id + "');";
                                context.Database.ExecuteSqlCommand(query);
                            }
                            else
                            {
                                MessageBox.Show("El rut de la persona "+ row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString() + " no coincide con el numero de contrato "+nContract);
                            }
                            
                            //edit contract isvalid
                           
                        }else if(nContract!=0){
                            MessageBox.Show("El contrato con numero " + nContract + " de la persona con rut "+ row.Cells[0].Value.ToString()+"-"+row.Cells[1].Value.ToString()+ " no existe");
                        }
                        


                    }

                }
               
                connection.Close();
            }
        }
    }
}

