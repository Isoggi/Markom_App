using MarkomApp.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class Employee : DeleteChanges
    {
        [Key]
        [MaxLength(11)]
        public int Id { get; set; }
        [Column(name:"EMPLOYEE_NUMBER")]
        [MaxLength(50)]
        public string Code { get; set; }
        [Column(name: "First_Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Column(name: "Last_Name")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Column(name: "M_Company_Id")]
        public string MCompanyId { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }

    }

}
