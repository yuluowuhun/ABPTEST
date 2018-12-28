using Abp.Web.Mvc.Views;

namespace ABPTEST.Web.Views
{
    public abstract class ABPTESTWebViewPageBase : ABPTESTWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPTESTWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPTESTWebViewPageBase()
        {
            LocalizationSourceName = ABPTESTConsts.LocalizationSourceName;
        }
    }
}