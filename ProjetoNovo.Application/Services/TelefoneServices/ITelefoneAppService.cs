using ProjetoNovo.Services.TelefoneServices.DTOsTelefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.TelefoneServices
{
    public interface ITelefoneAppService
    {
        Task<CreateTelefoneOutput> CreateTelefone(CreateTelefoneInput input);
        Task<UpdateTelefoneOutput> UpdateTelefone(UpdateTelefoneInput input);
        Task DeleteTelefone(long id);
        Task<GetAllTelefoneOutput> GetAllTelefone();
    }
}
