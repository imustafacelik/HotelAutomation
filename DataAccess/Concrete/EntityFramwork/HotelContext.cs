using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class HotelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database=Hotel; Trusted_Connection = true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmptyRoom> EmptyRooms { get; set; }


    }
}
