using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class User: DeleteChanges
    {
        [Key]
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [ForeignKey("M_Role_Id")]
        [MaxLength(11)]
        public int M_Role_Id { get; set; }
        [ForeignKey("M_Employee_Id")]
        [MaxLength(11)]
        public int M_Employee_Id { get; set; }

    }
}
