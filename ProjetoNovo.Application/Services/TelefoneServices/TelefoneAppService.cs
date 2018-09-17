using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoNovo.Entities.TelefoneEntity;
using ProjetoNovo.Entities.TelefoneEntity.Manager;
using ProjetoNovo.Services.TelefoneServices.DTOsTelefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.TelefoneServices
{
    public class TelefoneAppService : ApplicationService, ITelefoneAppService
    {
        private ITelefoneManager _telefoneManager;

        public TelefoneAppService(ITelefoneManager telefoneManager)
        {
            _telefoneManager = telefoneManager;
        }

        public async Task<CreateTelefoneOutput> CreateTelefone(CreateTelefoneInput input)
        {
            var telefone = input.MapTo<Telefone>();
            var createdTelefoneId = await _telefoneManager.Create(telefone);

            return new CreateTelefoneOutput
            {
                Id = createdTelefoneId
            };
        }

        public async Task DeleteTelefone(long id)
        {
            await _telefoneManager.Delete(id);
        }

        public async Task<GetAllTelefoneOutput> GetAllTelefone()
        {
            var telefone = await _telefoneManager.GetAllList();
            return new GetAllTelefoneOutput { Telefone = Mapper.Map<List<GetAllTelefoneId>>(telefone) };
        }


        public async Task<UpdateTelefoneOutput> UpdateTelefone(UpdateTelefoneInput input)
        {
            var telefone = input.MapTo<Telefone>();
            var telefoneAtualizado = await _telefoneManager.Update(telefone);
            return telefoneAtualizado.MapTo<UpdateTelefoneOutput>();
        }
    }
}
