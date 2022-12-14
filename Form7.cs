using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace Aplicacion_RRHH
{
    public partial class Form7 : Form
    {
        private DbTransaction transaction;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.conectionDb();
            connection.Open();

            // DbConnection that is already opened
            using (Db context = new Db(connection, false))
            {
                

                foreach (DataGridViewRow row in dgItems.Rows)
                {
                    Debug.WriteLine(row);
                    if(row.Cells[0].Value != null)
                    {
                        Employee employee = new Employee();
                        Contract contract = new Contract();
                        string rutStr = row.Cells[0].Value.ToString();
                        if (rutStr != "")
                        {
                            int rut = 0;
                          
                            try
                            {
                                rut = Convert.ToInt32(rutStr);
                                System.Console.WriteLine(rut);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid String");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("The string cannot fit in 32 bit value");
                            }
                            // verificar si existe el rut
                            if(context.employees.Where(x => x.rut == rut).Count()<=0)
                            {
                                employee.rut = rut;
                                employee.dv = row.Cells[1].Value.ToString();
                                employee.name = row.Cells[2].Value.ToString();
                                employee.lastnameM = row.Cells[3].Value.ToString();
                                employee.lastnameP = row.Cells[4].Value.ToString();
                                context.employees.Add(employee);
                            }
                            else
                            {
                                employee = context.employees.Where(x => x.rut == rut).First();
                            }
                            //Debug.WriteLine(context.contracts.Where(x => x.rut == employee.rut + "-" + employee.dv).First());

                            // verificar si el empleado tiene contrato valido
                            if (context.contracts.Where(x => x.rut == employee.rut + "-"+employee.dv).Count()>0){
                                bool isValid = false;
                                List<Contract> contractAux = context.contracts.Where(x => x.rut == employee.rut + "-"+employee.dv).ToList();
                                foreach(Contract c in contractAux)
                                {
                                    if (c.isValid)
                                    {
                                        isValid = true;
                                    }
                                }
                   
                                if (!isValid)
                                {
                                    contract.isValid = true;
                                    contract.job = row.Cells[7].Value.ToString();
                                    contract.rut = rut + "-" + employee.dv;
                                    contract.proyect = row.Cells[6].Value.ToString();
                                    contract.typeContract = row.Cells[9].Value.ToString();
                                    contract.nameEmployee = employee.name;
                                    contract.workingDay = row.Cells[5].Value.ToString();
                                    try
                                    {
                                        contract.startDate = Convert.ToDateTime(row.Cells[8].Value.ToString());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid String");
                                    }
                                    if (contract.typeContract == "TEMPORAL")
                                    {
                                        int months = row.Cells[10].Value.ToString() == "" ? 0 : Convert.ToInt32(row.Cells[10].Value.ToString());
                                        contract.endDate = contract.startDate.AddMonths(months);
                                    }
                                    else
                                    {
                                        contract.endDate = new DateTime(9999, 12, 31);
                                    }
                                    string salaryStr = row.Cells[11].Value.ToString();
                                    int salary = 0;
                                    string[] charsToRemove = new string[] { "$", "." };
                                    foreach (var c in charsToRemove)
                                    {
                                        salaryStr = salaryStr.Replace(c, "");
                                    }
                                    try
                                    {
                                        salary = Convert.ToInt32(salaryStr);
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid String");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("The string cannot fit in 32 bit value");
                                    }

                                    contract.salary = salary;
                                    Random rnd = new Random();
                                    int contractNumber = rnd.Next(100000, 999999);
                                    while (context.contracts.Where(c => c.nContract == contractNumber).Count() > 0)
                                    {
                                        contractNumber = rnd.Next(100000, 999999);
                                    }

                                    contract.nContract = contractNumber;
                                    contract.Employee = employee;
                                    context.contracts.Add(contract);
                                    context.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("El rut " + rut+"-"+employee.dv+ " ya tiene un contrato valido");
                                }
                            }
                            else
                            {
                                contract.isValid = true;
                                contract.job = row.Cells[7].Value.ToString();
                                contract.rut = rut + "-" + employee.dv;
                                contract.proyect = row.Cells[6].Value.ToString();
                                contract.typeContract = row.Cells[9].Value.ToString();
                                contract.nameEmployee = employee.name;
                                contract.workingDay = row.Cells[5].Value.ToString();
                                try
                                {
                                    contract.startDate = Convert.ToDateTime(row.Cells[8].Value.ToString());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid String");
                                }
                                if (contract.typeContract == "TEMPORAL")
                                {
                                    int months = row.Cells[10].Value.ToString() == "" ? 0 : Convert.ToInt32(row.Cells[10].Value.ToString());
                                    contract.endDate = contract.startDate.AddMonths(months);
                                }
                                string salaryStr = row.Cells[11].Value.ToString();
                                int salary = 0;
                                string[] charsToRemove = new string[] { "$", "." };
                                foreach (var c in charsToRemove)
                                {
                                    salaryStr = salaryStr.Replace(c, "");
                                }
                                try
                                {
                                    salary = Convert.ToInt32(salaryStr);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid String");
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine("The string cannot fit in 32 bit value");
                                }

                                contract.salary = salary;
                                Random rnd = new Random();
                                int contractNumber = rnd.Next(100000, 999999);
                                while (context.contracts.Where(c => c.nContract == contractNumber).Count() > 0)
                                {
                                    contractNumber = rnd.Next(100000, 999999);
                                }

                                contract.nContract = contractNumber;
                                contract.Employee = employee;
                                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                                context.contracts.Add(contract);
                                context.SaveChanges();
                            }
                            
                      
                            
                            

                        }
                        
                        
                    }
                }


                context.SaveChanges();
                MessageBox.Show("Contrataciones ingresadas con exito");
                connection.Close();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            {
                                if (data[0] != null)
                                {
                                    dr[k] = data[k];
                                }
                            
                            }
                              
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
