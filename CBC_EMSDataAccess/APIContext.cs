namespace CBC_APIDataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using CBC_APIDataEntitiesV1;

    public partial class APIContext : DbContext
    {
        public APIContext()
            : base("name=APIContext")
        {
        }


        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeVacation> EmployeeVacations { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
