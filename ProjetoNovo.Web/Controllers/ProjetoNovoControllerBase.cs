using Abp.Web.Mvc.Controllers;

namespace ProjetoNovo.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ProjetoNovoControllerBase : AbpController
    {
        protected ProjetoNovoControllerBase()
        {
            LocalizationSourceName = ProjetoNovoConsts.LocalizationSourceName;
        }
    }
}