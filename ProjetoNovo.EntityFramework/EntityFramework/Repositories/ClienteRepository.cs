using Abp.EntityFramework;
using ProjetoNovo.Entities.ClienteEntity;
using ProjetoNovo.Entities.ClienteEntity.Manager;
using ProjetoNovo.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.EntityFramework.Repositories
{
    public class ClienteRepository : ProjetoNovoRepositoryBase<Cliente, long>, IClienteRepository
    {
        public ClienteRepository(IDbContextProvider<ProjetoNovoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async new Task<Cliente> UpdateAsync(Cliente entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Entry(entity.Documento).State = EntityState.Modified;
            foreach (var telefone in entity.Telefones)
            {
                Context.Entry(telefone).State = EntityState.Modified;
            }            
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task Add(Cliente cliente, Pedido pedido)
        {
            cliente.Pedidos.Add(pedido);
            await Context.SaveChangesAsync();
        }



    }
}
