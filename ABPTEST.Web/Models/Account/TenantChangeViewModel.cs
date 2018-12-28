﻿using Abp.AutoMapper;
using ABPTEST.Sessions.Dto;

namespace ABPTEST.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}