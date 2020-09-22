using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Shared.Dto
{
    public class UserDto : ChangesDto
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int MRoleId { get; private set; }
        public int MEmployeeId { get; private set; }
    }
}
