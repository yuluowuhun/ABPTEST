using System.Threading.Tasks;
using Abp.Application.Services;
using ABPTEST.Sessions.Dto;

namespace ABPTEST.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
