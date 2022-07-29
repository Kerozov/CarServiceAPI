using CarService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarServiceAPI.Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options)
             : base(options)
        {

        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Requests> Requests { get; set; }


    }
}
