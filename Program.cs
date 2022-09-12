using Aplicacion_RRHH.BD;
using Aplicacion_RRHH.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    internal static class Program
    {
        static MySqlConnection connection1;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static MySqlConnection conectionDb()
        {
            string connectionString = "server=localhost;port=3306;database=rrhh;uid=root;password=admin123";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create database if not exists
                using (Db contextDB = new Db(connection, false))
                {
                    contextDB.Database.CreateIfNotExists();
                }
                
                return connection;


            }

        }

    }
}
