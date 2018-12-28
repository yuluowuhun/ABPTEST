using System.Threading.Tasks;
using Abp.Application.Services;
using ABPTEST.Configuration.Dto;

namespace ABPTEST.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}