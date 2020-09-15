using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class MenuAccess : DeleteChanges
    {
        public int Id { get; set; }
        public int MRoleId { get; set; }
        public int MMenuId { get; set; }
    }
}
