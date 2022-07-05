using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLReservation
    {
        private static BLLReservation _Instance;
        public static BLLReservation Instance { get => _Instance; set => _Instance = value; }

        private List<Reservation> lsIdReservationPay()
        {   List<Reservation> ls = new List<Reservation>();
            List<Reservation> data = Common.Intance.Reservations.ToList();
            foreach(Reservation reservation in data)
            {
                if(DateTime.Compare(reservation.CheckOut,DateTime.Today) <= 0)
                {
                    ls.Add(reservation);
                }
            }
            return ls;
        }
        public double TotalPay(string idReservation)

        {
            Reservation rs = Common.Intance.Reservations.Find(idReservation);
            double total = 0;
            double moneyRoom = DateTime.Compare(rs.CheckOut,rs.CheckIn) * rs.Room.TypeRoom.PriceTypeRoom;
            double moneyService = 0;
            foreach(Service i in rs.Services)
            {
                moneyService += i.Price;
            }
            total = moneyService + moneyRoom;
            return total;
            

        }
        private void showBills()
        {
            List<Bill> bills = new List<Bill>();
            foreach(Reservation i in lsIdReservationPay()){
                bills.Add(new Bill { Reservation = i,DatePay = i.CheckIn,Total = TotalPay(i.ID_Reservation) });

            }
        }
        
    }
}
