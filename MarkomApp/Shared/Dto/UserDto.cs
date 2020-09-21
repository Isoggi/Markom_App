using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Shared.Dto
{
    public class UserDto : ChangesDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int M_Role_Id { get; set; }
        public int M_Employee_Id { get; set; }
    }
}
