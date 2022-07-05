using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public double TotalAmount { get; set; }
    }
    public class Dashboard
    {

        //Fields & properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumServices { get; private set; }
        public int NumRooms { get; private set; }
        public int NumEmployees { get; private set; }
        public List<KeyValuePair<string, int>> TopTypeRoomList { get; private set; }
        //   public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumReservations { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalProfit { get; set; }
        //Constructor
        public Dashboard()
        {
        }
        private void GetNumberItems()
        {

            //Get Total Number of Services

            NumServices = Common.Intance.Services.Count();
            //Get Total Number of Rooms

            NumRooms = Common.Intance.Rooms.Count();
            //Get Total Number of Employes

            NumEmployees = Common.Intance.Employees.Count();
            //Get Total Number of Reservation
            NumReservations = Common.Intance.Reservations.Count();
        }
        private void GetTyoeRoomAnalist()
        {
            TopTypeRoomList = new List<KeyValuePair<string, int>>();
            //get top 3 type room
            var data = (from Reservation in Common.Intance.Reservations
                        group Reservation.Room.TypeRoom.NameTypeRoom by Reservation.Room.TypeRoom.NameTypeRoom into TypeRooms
                        select new
                        {
                            NameTypeRoom = TypeRooms.Key,
                            numberOfOrder = TypeRooms.Count()
                        }).OrderByDescending(x => x.numberOfOrder).Distinct().Take(3);

            foreach (var item in data.ToList())
            {
                TopTypeRoomList.Add(new KeyValuePair<string, int>(item.NameTypeRoom.ToString(), item.numberOfOrder));
                
            }




        }
        private double GetTotalSalaryEmployee()
        {
            var TotalSalary = Common.Intance.Employees.Select(p => p.Salary).Sum();
            return TotalSalary;
        }
        private void GetOrderAnalist()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            var billIsPaid = Common.Intance.Bills.Where(p => p.IsPaid == true && p.DatePay >= startDate && p.DatePay <= endDate);
            var data = billIsPaid.Select(p => new { p.DatePay, p.Total });
            var resultTable = new List<KeyValuePair<DateTime, double>>();
            foreach (var item in data.ToList())
            {
                resultTable.Add(new KeyValuePair<DateTime, double>(item.DatePay, item.Total));
                TotalRevenue += item.Total;
            }
            TotalProfit = TotalRevenue - GetTotalSalaryEmployee();
            

            if (numberDays <= 1)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Weeks
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Years
            else
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }




        }
        // public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetTyoeRoomAnalist();
                GetOrderAnalist();
                

                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }






    }
}

