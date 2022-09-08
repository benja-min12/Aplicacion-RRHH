using Aplicacion_RRHH.Model;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_RRHH.BD
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Db: DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Contract> contracts { get; set; }

        public Db(): base()
        {
            
        }
        // Constructor to use on a DbConnection that is already opened
        public Db(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().MapToStoredProcedures().Property(p => p.dv)
            .HasColumnType("char"); ;
            modelBuilder.Entity<Contract>().MapToStoredProcedures();
            //relacion 1 a muchos entre employe y contract


        }
    }
}
