using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Reservations = new HashSet<Reservation>();
        }
        [Key]
        [StringLength(20)]
        [Required]
        public string ID_Customer { get; set; }
        [StringLength(20)]
        public string NameCustomer { get; set; }
        
        public bool Gender { get; set; }
        [StringLength(100)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string CCCD { get; set; }

     
    
        public ICollection<Reservation> Reservations { get; set; }

    }
}
