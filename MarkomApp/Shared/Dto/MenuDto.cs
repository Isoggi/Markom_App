using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Shared.Dto
{
    public class MenuDto : ChangesDto
    {
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Controller { get; private set; }
        public string ParentId { get; private set; }

    }
}
