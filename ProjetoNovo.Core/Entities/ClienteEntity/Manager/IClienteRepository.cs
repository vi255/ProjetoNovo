using Abp.Domain.Repositories;
using ProjetoNovo.Entities.ClienteEntity;
using ProjetoNovo.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.ClienteEntity.Manager
{
    public interface IClienteRepository : IRepository<Cliente, long>
    {
        new Task<Cliente> UpdateAsync(Cliente entity);
        Task Add(Cliente cliente, Pedido pedido);
    }
}
