using DLL_Library_NET_Project.Persistance.DAO;
using Microsoft.EntityFrameworkCore;

namespace DLL_Library_NET_Project.Persistance
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:axelnl.database.windows.net,1433;Initial Catalog=net_project_db;Persist Security Info=False;User ID=AxelNL;Password=MDPserv.cesi16;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<ActeurDAO> Acteur { get; set; }
        public DbSet<ActionDAO> Action { get; set; }
        public DbSet<ScenarioDAO> Scenario { get; set; }
        public DbSet<ActionScenarioDAO> ActionScenario { get; set; }
        public DbSet<RecetteDAO> Recette { get; set; }
        public DbSet<TypeRecetteDAO> TypeRecette { get; set; }
    }
}