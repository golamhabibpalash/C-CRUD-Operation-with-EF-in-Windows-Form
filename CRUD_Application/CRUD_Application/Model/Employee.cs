using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Dob { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public string ImageURL { get; set; }
    }
}
