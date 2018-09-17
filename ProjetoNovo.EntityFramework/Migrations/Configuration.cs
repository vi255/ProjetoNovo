using ProjetoNovo.EntityFramework;
using System.Data.Entity.Migrations;


namespace ProjetoNovo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoNovoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjetoNovo";
        }

        protected override void Seed(ProjetoNovoDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
