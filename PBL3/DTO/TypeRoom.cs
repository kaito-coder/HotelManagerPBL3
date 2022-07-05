using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;



namespace PBL3.Model
{
    public partial class TypeRoom
    {
        public TypeRoom()
        {
            this.Rooms = new HashSet<Room>();
        }
        [Key]
        [Required]
        
        public int ID_TypeRoom { get; set; }
        [StringLength(100)]

        public string NameTypeRoom { get; set; }
        public double PriceTypeRoom { get; set; }
        public int NumberOfBed { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
