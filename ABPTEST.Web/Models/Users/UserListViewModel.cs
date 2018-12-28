using System.Collections.Generic;
using ABPTEST.Roles.Dto;
using ABPTEST.Users.Dto;

namespace ABPTEST.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}