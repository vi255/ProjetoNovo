using System.Data.Common;
using System.Data.Entity;
using Abp.Domain.Repositories;
using Abp.EntityFramework;
using ProjetoNovo.Entities.ClienteEntity;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity;
using ProjetoNovo.Entities.TelefoneEntity;
using ProjetoNovo.EntityFramework.Repositories;


namespace ProjetoNovo.EntityFramework
{

    public class ProjetoNovoDbContext : AbpDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                    .HasMany(l => l.Pedidos)
                    .WithMany(a => a.Clientes)
                    .Map(x =>
                    {
                        x.MapLeftKey("ClienteId");
                        x.MapRightKey("PedidoId");
                        x.ToTable("ClientePedido");
                    });
            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<Cliente> Clientes { get; set; }

        public virtual IDbSet<Documento> Documentos { get; set; }

        public virtual IDbSet<Pedido> Pedidos { get; set; }

        public virtual IDbSet<Telefone> Telefones { get; set; }


        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ProjetoNovoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ProjetoNovoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ProjetoNovoDbContext since ABP automatically handles it.
         */
        public ProjetoNovoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ProjetoNovoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ProjetoNovoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
