using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.TelefoneEntity.Manager
{
    public interface ITelefoneManager
    {
        Task<long> Create(Telefone telefone);
        Task<Telefone> Update(Telefone telefone);
        Task Delete(long id);
        Task<Telefone> GetById(long id);
        Task<List<Telefone>> GetAllList();
    }
}
