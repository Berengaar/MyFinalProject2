using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje class'larını ilişkilendirmek bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       //Bu kısmı doğru yazdığından emin ol yoksa hata verir
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        #region Description
        //Aşağıdaki yapı benim elimdeki categorilerle 
        #endregion
        public DbSet<Product> Products { get; set; }        //Database'deki adlarını yazarız en sağa
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
