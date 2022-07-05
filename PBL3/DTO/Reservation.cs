using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    public class Reservation
    {
        public Reservation()
        {
            this.Bills = new HashSet<Bill>();
            this.Services = new HashSet<Service>();
           
        }
        [Key]
        [StringLength(20)]
        [Required]
        public string  ID_Reservation { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CheckIn { get; set; }

        [DataType(DataType.DateTime)]

        public DateTime CheckOut { get; set; }
        
        public string ID_Room { get; set; }
        [StringLength(20)]
        public string ID_Customer { get; set; }
      
        public virtual Room Room { get; set; }
        public virtual Customer Customer { get; set; }
          
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        
    }
}
