using EFDemo.DomainModel;

namespace EFDemo.DAL
{
    using System.Data.Entity;

    public class DemoContext : DbContext
    {
        // Your context has been configured to use a 'DemoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFDemo.DAL.DemoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DemoContext' 
        // connection string in the application configuration file.
        public DemoContext()
            : base("name=DefaultConnection")
        {
            // DB Initializer doesn't work with Migrations (yet)
            //Database.SetInitializer(new DemoSeed());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // use convensions when possible

            // read about fluent api http://msdn.microsoft.com/en-us/data/jj591617.aspx
        }
    }
}
