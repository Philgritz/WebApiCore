using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProject.Models {
    public class Customer {

        public int Id { get; set; }  //tell EF to make changes in Db
        [Required]  //makes name in db not null
        [StringLength(50)]  //limits str length in db
        public string Name { get; set; }  
        public double Sales { get; set; }
        public bool Active { get; set; }

        public Customer() {}
    }
}
