using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{ 
    public class Common
    {
        private static HotelManagerContext _Instance = new HotelManagerContext();

        public static HotelManagerContext Intance { get => _Instance; set => _Instance = value; }
    }
}
