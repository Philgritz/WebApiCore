using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProject.Models {
    public class Employee {
        
        
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Employee() {}
    }
}
