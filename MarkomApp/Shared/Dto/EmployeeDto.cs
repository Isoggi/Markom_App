using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Shared.Dto
{
    public class EmployeeDto : ChangesDto
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MCompanyId { get; private set; }
        public string Email { get; private set; }
    }
}
