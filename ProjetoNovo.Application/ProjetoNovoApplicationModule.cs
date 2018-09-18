using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using ProjetoNovo.Entities.ClienteEntity;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity;
using ProjetoNovo.Entities.TelefoneEntity;
using ProjetoNovo.Services.ClienteServices.DTOs;
using ProjetoNovo.Services.DocumentoServices.DTOsDocumento;
using ProjetoNovo.Services.PedidoServices.DTOsPedido;
using ProjetoNovo.Services.TelefoneServices.DTOsTelefone;

namespace ProjetoNovo
{
    [DependsOn(typeof(ProjetoNovoCoreModule), typeof(AbpAutoMapperModule))]
    public class ProjetoNovoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateClienteInput, Cliente>()
                .ConstructUsing(x => new Cliente(x.Name, x.Status, x.Documento, x.Telefones));

                config.CreateMap<UpdateClienteInput, Cliente>()
                .ConstructUsing(x => new Cliente(x.Name, x.Status, x.Documento, x.Telefones));

                config.CreateMap<CreateDocumentoInput, Documento>()
                .ConstructUsing(x => new Documento(x.TipoDocumento, x.NumeroDocumento));

                config.CreateMap<UpdateDocumentoInput, Documento>()
                .ConstructUsing(x => new Documento(x.TipoDocumento, x.NumeroDocumento));

                config.CreateMap<CreatePedidoInput, Pedido>()
                .ConstructUsing(x => new Pedido(x.NomeProduto, x.PrazoEntrega));

                config.CreateMap<UpdatePedidoInput, Pedido>()
                .ConstructUsing(x => new Pedido(x.NomeProduto, x.PrazoEntrega));

                config.CreateMap<CreateTelefoneInput, Telefone>()
                .ConstructUsing(x => new Telefone(x.NumeroTelefone, x.TipoTelefone, x.ClienteId));

                config.CreateMap<UpdateTelefoneInput, Telefone>()
                .ConstructUsing(x => new Telefone(x.NumeroTelefone, x.TipoTelefone, x.ClienteId));
            });
        }

        public override void Initialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration => {
                configuration.CreateMissingTypeMaps = true;
            });

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
