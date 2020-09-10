using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkomApp.Models
{
    public class User: CreateUpdate
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string M_Employee_Id { get; set; }

    }
}
