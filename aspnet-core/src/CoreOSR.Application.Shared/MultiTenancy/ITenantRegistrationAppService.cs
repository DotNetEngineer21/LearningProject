using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.Editions.Dto;
using CoreOSR.MultiTenancy.Dto;

namespace CoreOSR.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}