using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_lab5.Models;

namespace ASP.NET_lab5.Data
{
    public class ASPNET_lab5Context : DbContext
    {
        public ASPNET_lab5Context (DbContextOptions<ASPNET_lab5Context> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_lab5.Models.Meal> Meal { get; set; }
    }
}
