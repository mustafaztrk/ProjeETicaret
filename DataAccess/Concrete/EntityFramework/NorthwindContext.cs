using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//proje hangi veri tabanı ile iliskili oldugunun belirtilmesi
        {
            //kullandıgımız sql servere nasıl baglancagını belirtiyorum
            // optionsBuilder.UseSqlServer(@"Server=175.45.2.12");//ipden alıcaksak
             optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
                                         //        veri tabanının koumu: o konumaki hangi db; kullanıcı adı şifre kısmı
        }


        //db toblo ve nesne eşlenmesi
        public DbSet<Product> Products { get; set; }// product nesnemi veritabanındaki products tablosu ile bagla
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
