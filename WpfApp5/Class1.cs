using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace WpfApp5
{
    public class applicationContext : DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Stuff> stuff { get; set; }
        public DbSet<Supply> supply { get; set; }
        public DbSet<Provider> provider { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Accounting> accounting { get; set; }

        public applicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                "server=127.0.0.1;port=3306;user=root;password=root;database=zoo;"
                );
        }
        //PRODUCTS
        public static List<Products> ShowGridProducts()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.products.ToList();
            }
        }
        public static void AddProduct(Products t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.products.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveProduct(Products t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.products.Remove(t);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(Products t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.products.Update(t);
                db.SaveChanges();
            }
        }
        //STUFF
        public static List<Stuff> ShowGridStuff()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.stuff.ToList();
            }
        }
        public static void AddStuff(Stuff t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.stuff.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveStuff(Stuff t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.stuff.Remove(t);
                db.SaveChanges();
            }
        }

        public static void UpdateStuff(Stuff t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.stuff.Update(t);
                db.SaveChanges();
            }
        }
        //SUPPLY
        public static List<Supply> ShowGridSupply()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.supply.ToList();
            }
        }
        public static void AddSupply(Supply t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.supply.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveSupply(Supply t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.supply.Remove(t);
                db.SaveChanges();
            }
        }

        public static void UpdateSupply(Supply t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.supply.Update(t);
                db.SaveChanges();
            }
        }
        //PROVIDER
        public static List<Provider> ShowGridProvider()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.provider.ToList();
            }
        }
        public static void AddProvider(Provider t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.provider.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveProvider(Provider t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.provider.Remove(t);
                db.SaveChanges();
            }
        }
        public static void UpdateProvider(Provider t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.provider.Update(t);
                db.SaveChanges();
            }
        }
        //SALE
        public static List<Sale> ShowGridSale()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.sale.ToList();
            }
        }
        public static void AddSale(Sale t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.sale.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveSale(Sale t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.sale.Remove(t);
                db.SaveChanges();
            }
        }
        public static void UpdateSale(Sale t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.sale.Update(t);
                db.SaveChanges();
            }
        }
        //CUSTOMERS
        public static List<Customers> ShowGridCustomer()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.customers.ToList();
            }
        }
        public static void AddCustomer(Customers t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.customers.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveCustomer(Customers t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.customers.Remove(t);
                db.SaveChanges();
            }
        }
        public static void UpdateCustomer(Customers t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.customers.Update(t);
                db.SaveChanges();
            }
        }
        //ACCOUNTING 
        public static List<Accounting> ShowGridAccounting()
        {
            using (applicationContext db = new applicationContext())
            {
                return db.accounting.ToList();
            }
        }
        public static void AddAccounting(Accounting t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.accounting.Add(t);
                db.SaveChanges();
            }
        }
        public static void RemoveAccounting(Accounting t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.accounting.Remove(t);
                db.SaveChanges();
            }
        }
        public static void UpdateAccounting(Accounting t)
        {
            using (applicationContext db = new applicationContext())
            {
                db.accounting.Update(t);
                db.SaveChanges();
            }
        }
    }
}
