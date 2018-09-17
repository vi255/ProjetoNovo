using Abp.Application.Services;

namespace ProjetoNovo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ProjetoNovoAppServiceBase : ApplicationService
    {
        protected ProjetoNovoAppServiceBase()
        {
            LocalizationSourceName = ProjetoNovoConsts.LocalizationSourceName;
        }
    }
}