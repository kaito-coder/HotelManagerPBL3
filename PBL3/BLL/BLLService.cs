using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLService
    {
        private static BLLService _Instance;
        public static BLLService Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLService();
                }
                return _Instance;
            }
            private set { }
        }
        
        public void DeleteService(Service obj)
        {
            Common.Intance.Services.Remove(obj);
            Common.Intance.SaveChanges();
        }
                
    }
}
