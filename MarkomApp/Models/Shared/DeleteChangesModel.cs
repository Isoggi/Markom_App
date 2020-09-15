using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models.Shared
{
    public class DeleteChanges: Changes
    {

        [Column(name: "is_delete")]
        public bool IsDelete { get; set; } = false;
    }
}
