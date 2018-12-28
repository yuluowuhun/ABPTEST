﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPTEST.MultiTenancy.Dto;

namespace ABPTEST.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
