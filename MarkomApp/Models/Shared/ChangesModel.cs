using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models.Shared
{
    public class Changes
    {
        [Column(name: "created_by")]
        public string CreatedBy { get; set; }
        [Column(name: "created_date")]
        public DateTime CreatedDate { get; set; }
        [Column(name: "updated_by")]
        public string UpdatedBy { get; set; }
        [Column(name: "updated_date")]
        public DateTime UpdatedDate { get; set; }
    }
}
