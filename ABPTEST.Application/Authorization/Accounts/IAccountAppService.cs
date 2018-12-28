using System.Threading.Tasks;
using Abp.Application.Services;
using ABPTEST.Authorization.Accounts.Dto;

namespace ABPTEST.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
