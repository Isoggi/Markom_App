using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Shared.Dto
{
    public class CompanyDto : ChangesDto
    {
        public string Id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

    }
}
