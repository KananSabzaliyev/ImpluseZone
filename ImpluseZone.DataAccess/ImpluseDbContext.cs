using ImpluseZone.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace ImpluseZone.DataAccess
{
     public class ImpluseDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-7U3FDJJ\\SQLEXPRESS;Database=ImpluseDb;uid=sa;pwd=admin");
        }

        public DbSet<Impluse> Impluses { get; set; }
    }
}
