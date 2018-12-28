using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPTEST.Configuration.Dto;

namespace ABPTEST.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPTESTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
