using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PBL3.DTO;

namespace PBL3.Model
{
    public class Employee
    {

        [Key]
        [StringLength(20)]
        [Required]
        public string ID_Employee { get; set; }
        [StringLength(100)]
        public string NameEmployee { get; set; }
        public bool Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [StringLength(100)]
        public string Phone { get; set; } 

        [StringLength(100)]
        public string CCCD { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_In { get; set; }

        public double Salary { get; set; }
        [StringLength(100)]

        public string Role { get; set; }

        public virtual Account Account { get; set; } 
        






    }
    
}
