using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class Unit : DeleteChanges
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
