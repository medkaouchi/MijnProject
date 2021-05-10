using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MijnProject
{
    class ProjectContext:DbContext
    {
        public ProjectContext() : base("name = PeojectDBConnectString")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<ProjectContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adressen { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Bezorger> Bezorgers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Levrancier> Levranciers { get; set; }
    }
}
