using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    public class Room
    {
        public Room()
        {
            this.Reservations = new HashSet<Reservation>();
        }
        [Key]
        [StringLength(20)]
        [Required]
        public string ID_Room { get; set; }
        public int ID_TypeRoom { get; set; }
        public int ID_StatusRoom { get; set; }

        public virtual TypeRoom TypeRoom { get; set; }
        public virtual StatusRoom StatusRoom { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
