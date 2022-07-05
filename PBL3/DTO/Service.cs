using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    public class Service
    {
        public Service()
        {
            this.Reservations = new HashSet<Reservation>();    
        }
        [Key]
        [StringLength(20)]
        [Required]
        public string ID_Service { get; set; }
        [StringLength(100)]

        public string NameService { get; set; }

        public double Price { get; set; }

        public virtual ICollection<Reservation> Reservations {get;set;}
       
        
    }
}
