using ProjetoNovo.Services.DocumentoServices.DTOsDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.DocumentoServices
{
    public interface IDocumentoAppService
    {
        Task<CreateDocumentoOutput> CreateDocumento(CreateDocumentoInput input);
        Task<UpdateDocumentoOutput> UpdateDocumento(UpdateDocumentoInput input);
        Task DeleteDocumento(long id);
        Task<GetAllDocumentoOutput> GetAllDocumento();
    }
}
