using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    public class StatusRoom
    {
        public StatusRoom()
        {
            this.Rooms = new HashSet<Room>();
        }
        [Key]
        [Required]
        
        public int ID_StatusRoom { get; set; }
        [StringLength(100)]

        public string NameStatusRoom{ get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
