using PBL3.DTO;
using PBL3.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3
{
    public class HotelManagerContext : DbContext
    {
        // Your context has been configured to use a 'HotelManagerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3.HotelManagerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HotelManagerContext' 
        // connection string in the application configuration file.
        public HotelManagerContext()
            : base("name=HotelManagerContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
   
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<StatusRoom> StatusRooms { get; set; }
        public virtual DbSet<TypeRoom> TypeRooms { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }







    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}