using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PBL3.Model
{
    public class Bill
    {
        [Key]
        [Required]
        
        public int ID_Bill { get; set; }
        [StringLength(100)]        
        
        public string ID_Reservation { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DatePay { get; set; }

        public double Total { get; set; }

        public string PaymentMethod { get; set; }
        public bool IsPaid { get; set; }

        public virtual Reservation Reservation { get; set; }    

    }
}
