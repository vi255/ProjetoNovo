using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.DocumentoEntity.Manager
{
    public interface IDocumentoManager
    {
        Task<long> Create(Documento documento);
        Task<Documento> Update(Documento documento);
        Task Delete(long id);
        Task<Documento> GetById(long id);
        Task<List<Documento>> GetAllList();
    }
}
