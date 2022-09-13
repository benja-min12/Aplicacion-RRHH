using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
        }
    }
}
