using DLL_Library_NET_Project.Persistance.DAO;
using Microsoft.EntityFrameworkCore;

namespace DLL_Library_NET_Project.Persistance
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MO9QGPH;Database=net_project_db;User Id=sa;Password=root;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionScenarioDAO>().HasKey(i => new { i.actionId, i.scenarioId });
        }

        public DbSet<ActeurDAO> Acteur { get; set; }
        public DbSet<ActionDAO> Action { get; set; }
        public DbSet<ScenarioDAO> Scenario { get; set; }
        public DbSet<ActionScenarioDAO> ActionScenario { get; set; }
        public DbSet<RecetteDAO> Recette { get; set; }
        public DbSet<TypeRecetteDAO> TypeRecette { get; set; }
    }
}