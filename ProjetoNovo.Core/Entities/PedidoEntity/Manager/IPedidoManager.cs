using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.PedidoEntity.Manager
{
    public interface IPedidoManager
    {
        Task<long> Create(Pedido pedido);
        Task<Pedido> Update(Pedido pedido);
        Task Delete(long id);
        Task<Pedido> GetById(long id);
        Task<List<Pedido>> GetAllList();
    }
}
