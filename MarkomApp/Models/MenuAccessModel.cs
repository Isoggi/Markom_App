using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    [Table("M_MENU_ACCESS")]
    public class MenuAccess : DeleteChanges
    {
        [Key]
        [MaxLength(11)]
        public int Id { get; set; }
        [ForeignKey("M_ROLE")]
        public int MRoleId { get; set; }
        [ForeignKey("M_MENU")]
        public int MMenuId { get; set; }
    }
}
