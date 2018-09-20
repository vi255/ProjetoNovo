using ProjetoNovo.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.ClienteEntity.Manager
{
    public interface IClienteManager
    {
        Task<long> Create(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task Delete(long id);
        Task<Cliente> GetByIdCliente(long id);
        Task<List<Cliente>> GetAllList();
        Task VincularPedido(Cliente cliente, Pedido pedido);
    }
}
