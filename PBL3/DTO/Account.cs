using PBL3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Account
    {
        [StringLength(100)]
        [Key]
        [Required]
        [ForeignKey("Employee")]
        public string ID_Employee { get; set; }
        [StringLength(100)]
        
        public string UserName { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [ForeignKey("ID_Employee")]
        public virtual Employee Employee { get; set; }
    }
}
