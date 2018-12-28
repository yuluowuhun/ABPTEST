﻿using System.Collections.Generic;
using System.Linq;
using ABPTEST.Roles.Dto;
using ABPTEST.Users.Dto;

namespace ABPTEST.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}