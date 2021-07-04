using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : DbContext  //To use Entity framework
    {
        public DataContext(DbContextOptions options) : base(options) //constructor-when the class is callled this is initialized 
        {

        }

        public DbSet<AppUser> Users { get; set; } //To create a class for which we need database for (Users is the table)
    }
}
