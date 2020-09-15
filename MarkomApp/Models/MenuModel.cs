using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class Menu : DeleteChanges
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string ParentId { get; set; }

    }
}
