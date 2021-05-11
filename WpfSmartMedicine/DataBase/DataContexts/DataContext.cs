using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WpfSmartMedicine.DataBase.Models;
using WpfSmartMedicine.src;

namespace WpfSmartMedicine.DataBase.DataContexts
{
    public class DataContext:DbContext
    {
        public string ConnectString = new SettingXML().XmlRead("SqlConnectString");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=NEWLAND-PC;Integrated Security=True;Initial Catalog=SmartMedicine");
            optionsBuilder.UseSqlServer(ConnectString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
           .HasCheckConstraint("CK_Age", "Age Between 0 AND 150")// 约束 年龄从0到150
           .HasCheckConstraint("CK_Sex", "sex ='男'or sex='女'");// 约束 性别只能为男或女
        }

        public DbSet<Room> Room { get; set; }

        public DbSet<SensorRecord> SensorRecord { get; set; }

        public DbSet<User> User { get; set; }
    }
}
