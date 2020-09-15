using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class Souvenir : DeleteChanges
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int MUnitId {get;set;}

    }
}
