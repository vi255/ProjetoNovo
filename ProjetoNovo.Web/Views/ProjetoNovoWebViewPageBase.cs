using Abp.Web.Mvc.Views;

namespace ProjetoNovo.Web.Views
{
    public abstract class ProjetoNovoWebViewPageBase : ProjetoNovoWebViewPageBase<dynamic>
    {

    }

    public abstract class ProjetoNovoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProjetoNovoWebViewPageBase()
        {
            LocalizationSourceName = ProjetoNovoConsts.LocalizationSourceName;
        }
    }
}