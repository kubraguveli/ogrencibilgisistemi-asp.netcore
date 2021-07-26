using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama2.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }
        
        public DbSet<OgrenciBilgi> OgrenciBilgileri { get; set; }
        public DbSet<OgrenciAdresBilgi> OgrenciAdresBilgileri { get; set; }
        public DbSet<OgrenciAileBilgi> OgrenciAileBilgileri { get; set; }
        public DbSet<OgrenciOkulBilgi> OgrenciOkulBilgileri { get; set; }
    }
}
