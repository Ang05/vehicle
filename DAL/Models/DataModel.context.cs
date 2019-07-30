using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using DAL.Util;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class vehiclecontext : DbContext
    {
        public vehiclecontext()
        {

        }

        public vehiclecontext(DbContextOptions<vehiclecontext> options)
            : base(options)
        { }

        public DbSet<supervisor> supervisor { set; get; }
        public DbSet<employee> employee { set; get; }
        public DbSet<department> department { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseNpgsql("User ID=postgres;Password=P@ssword;Host=localhost;Port=5432;Database=vehicle;Pooling=true;");
            }
        }
    }

    
}
